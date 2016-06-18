using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace OsmDownloader
{
	public partial class frmOsmSourceSelection : Form
	{
		public frmOsmSourceSelection()
		{
			InitializeComponent();
		}

		class OsmRegion
		{
			public string Name { get; set; }
			public string SubUrl { get; set; }			
		}

		private void FillOsmSourceListGeofabrik(OsmRegion region, TreeNodeCollection collToAdd, List<string> extensions)
		{
			WebClient client = new WebClient();
			Stream data;
			try
			{
				 data = client.OpenRead(region.SubUrl);
			}
			catch (WebException ex)
			{
				HttpWebResponse ws = (HttpWebResponse) ex.Response;
				if (ws.StatusCode == HttpStatusCode.NotFound)
				{
					return;
				}
				throw;
			}
			
			StreamReader reader = new StreamReader(data);
			string s = reader.ReadToEnd();
			List<OsmRegion> subRegions = new List<OsmRegion>();
			TreeNode n = new TreeNode(region.Name);

			Regex r = new Regex("href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))", RegexOptions.IgnoreCase | RegexOptions.Compiled);
			for (Match m = r.Match(s); m.Success; m = m.NextMatch())
			{
				string theMatch = m.Value.Replace("href=", "");
				theMatch = theMatch.Replace("\"", "");
				if (theMatch.Contains("http://"))
				{
					continue;
				}
				if (theMatch.EndsWith(".html") &&
						 !theMatch.StartsWith("/"))
				{
                    if (ckbLatestOnly.Checked &&
                        !theMatch.Contains("latest"))
                    {
                        continue;
                    }
                    theMatch = theMatch.Replace("./", "");
                    theMatch = theMatch.Replace(".html", "/");
                    subRegions.Add(new OsmRegion() { Name = theMatch.Replace("/", ""), SubUrl = region.SubUrl + theMatch });
                }
				else
				{
					foreach (string ext in extensions)
					{
						if (theMatch.EndsWith(ext))
						{
							theMatch = theMatch.Replace("./", "");
							n.Nodes.Add(new TreeNode() { Text = theMatch, Tag = (region.SubUrl + theMatch) });
						}
					}

					//if (theMatch.EndsWith("osm") ||
					//    theMatch.EndsWith("osm.pbf"))
					//{
					//  theMatch = theMatch.Replace("./", "");
					//  n.Nodes.Add(new TreeNode() { Text = theMatch, Tag = (region.SubUrl + theMatch) });
					//}
				}
			}

			foreach (OsmRegion subRegion in subRegions)
			{
				FillOsmSourceListGeofabrik(subRegion, n.Nodes, extensions);
			}
			collToAdd.Add(n);			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			tvOsmSources.BeginUpdate();
			//FillOsmSourceList(new OsmRegion() { Name = "Die Welt", SubUrl = "http://download.geofabrik.de/" }, tvOsmSources.Nodes, new List<string>(){"osm.pbf", "osm"});
			if (radioButton1.Checked)
			{
				List<string> ext = new List<string>();
				foreach (Control c in groupBox2.Controls)
				{
					if (c is CheckBox)
					{
						CheckBox cb = (CheckBox)c;
						if (cb.Enabled &&
								cb.Checked &&
                                (cb.Tag != null))
						{
							ext.Add((string)cb.Tag);
						}
					}
				}
				if (ext.Count == 0)
				{
					MessageBox.Show("Keine Dateitypen gewählt", "Fehler", MessageBoxButtons.OK);
					return;
				}
				FillOsmSourceListGeofabrik(new OsmRegion() { Name = "Die Welt", SubUrl = "http://download.geofabrik.de/" }, tvOsmSources.Nodes, ext);
			}
			
			//FillOsmSourceList(new OsmRegion() { Name = "Die Welt", SubUrl = "http://www.viewfinderpanoramas.org/dem3/" }, tvOsmSources.Nodes, new List<string> { "zip" });
			tvOsmSources.EndUpdate();
		}

		private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
		{
			if (e.Node != null &&
				e.Node.Tag != null)
			{
				tsLblOsmSourceUrl.Text = e.Node.Tag.ToString();
			}
			else
			{
				tsLblOsmSourceUrl.Text = "N/A";
			}

		}

		private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
		{
			TreeNode n = e.Node;
			foreach (TreeNode sn in n.Nodes)
			{
				sn.Checked = n.Checked;
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			chkFiletypeHGT.Enabled = !radioButton1.Checked;
			chkFiletypeOSM.Enabled = radioButton1.Checked;
			chkFiletypeOSMPBF.Enabled = radioButton1.Checked;
			chkFiletypePOLY.Enabled = radioButton1.Checked;
            ckbLatestOnly.Enabled = radioButton1.Checked;
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog d = new FolderBrowserDialog();
			d.ShowDialog();

			DownloadTraverse(tvOsmSources.Nodes, d.SelectedPath);
		}

		private void DownloadTraverse(TreeNodeCollection treeNodeCol, string dstFolder)
		{
			foreach (TreeNode n in treeNodeCol)
			{
				if (n.Nodes != null &&
						n.Nodes.Count > 0)
				{
					DownloadTraverse(n.Nodes, dstFolder);
				}

				if (n.Checked)
				{
					DownloadFile((string)n.Tag, dstFolder);
				}
			}
		}

		private void DownloadFile(string p, string dstFolder)
		{
			WebClient wc = new WebClient();
			lblDownloadState.Text = string.Format("Download: {0}", p);
			Application.DoEvents();
			string dstFile = Path.Combine(dstFolder, Path.GetFileName(p));
			if (File.Exists(dstFile))
			{
				File.Delete(dstFile);
			}
			wc.DownloadFile(p, dstFile);
		}
	}
}
