﻿using System.IO;
namespace Server.MirObjects.Actions
{
	[ActionCommand("CLEARNAMELIST")]
	public class ActionClearNameList : NPCAction
	{
		protected readonly string FileName;
		public ActionClearNameList(NPCSegment segment, string line, string[] parts) : base(segment, line, parts)
		{
			var quoteMatch = QuoteRegex.Match(line);
			var listPath = parts[1];
			if (quoteMatch.Success)
				listPath = quoteMatch.Groups[1].Captures[0].Value;
			FileName = Path.Combine(Settings.NameListPath, listPath);
			var sDirectory = Path.GetDirectoryName(FileName);
			if (!Directory.Exists(sDirectory))
				Directory.CreateDirectory(sDirectory);
			if (!File.Exists(FileName))
				return;
			InitializationSuccess = true;
		}
		public override void Execute(MapObject ob)
		{
			if (!InitializationSuccess) return;
			File.WriteAllLines(FileName, new string [] {});
		}
	}
}