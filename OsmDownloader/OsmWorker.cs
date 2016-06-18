using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace OsmDownloader
{
	class OsmWorker
	{
		private const string OSMOSIS_PROG = @"e:\OedM\programme\OSM\Freizeitkarte-Entwicklung\tools\osmosis\bin\osmosis.bat";
		private const string JAVA_PROG = @"e:\OedM\programme\java\jre\jre7\bin\java.exe";
		private const string SPLITTER_PROG = @"e:\OedM\programme\OSM\Freizeitkarte-Entwicklung\tools\splitter\splitter.jar";
		private const string GEONAMES_DATA = @"e:\OedM\programme\OSM\Freizeitkarte-Entwicklung\cities\cities15000.zip";
		private const string SEA_PRECOMP_DATA = @"e:\OedM\programme\OSM\Freizeitkarte-Entwicklung\sea\";


		public static void JoinMapDataWithElevation(string mapDataFile, string elevationDataFile, string outDataFile)
		{
			string param = string.Format("--read-pbf {0} --read-pbf {1} --merge --write-pbf {2} omitmetadata=true", 
																		mapDataFile,
																		elevationDataFile,
																		outDataFile);

			Process p = new Process();
			p.StartInfo = new System.Diagnostics.ProcessStartInfo();
			p.StartInfo.Arguments = param;
			p.StartInfo.EnvironmentVariables.Add("JAVA_OPTIONS", "-Xmx1500M");
			p.StartInfo.FileName = OSMOSIS_PROG;
			p.Start();
			p.WaitForExit();
		}

		public static void SplitMapData(int mapId, string mapDataFile, string outDataDir)
		{
			string param = string.Format("-Xmx1500M" + 
																		" -jar {0}" + 
																		" 2" + 
																		" --geonames-file={1}" + 
																		" --no-trimm" + 
																		" --precomp-sea={2}" + 
																		" --keep-complete=true" + 
																		" --mapid={3}0001" + 
																		" --max-nodes=800000" + 
																		" --output=xml" + 
																		" --output-dir={4}" +
																		" {5}",
																		SPLITTER_PROG,
																		GEONAMES_DATA,
																		SEA_PRECOMP_DATA,
																		mapId,
																		outDataDir,
																		mapDataFile);
			Process p = new Process();
			p.StartInfo = new System.Diagnostics.ProcessStartInfo();
			p.StartInfo.FileName = JAVA_PROG;
			p.StartInfo.Arguments = param;
			p.Start();
			p.WaitForExit();
		}
	}
}
