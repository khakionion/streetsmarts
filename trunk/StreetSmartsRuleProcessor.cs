using System;
using System.Collections;
using System.IO;

namespace StreetSmarts
{
	/// <summary>
	/// Summary description for StreetSmartsRuleProcessor.
	/// </summary>
	public class StreetSmartsRuleProcessor
	{
		private Queue Actions;
		private Queue Parameters;
		private string[] Files;
		public StreetSmartsRuleProcessor()
		{
			Actions = new Queue();
			Parameters = new Queue();
			Files = Directory.GetFiles(@"C:\","*");
			Environment.CurrentDirectory = @"C:\";
		}
		/// <summary>
		/// Adds an action to be performed when ProcessRuleset() is invoked.
		/// </summary>
		public void AddAction(string Input)
		{
			string [] Intermediary = Input.Split(" ".ToCharArray());
			for(int i=0;i<Intermediary.Length;i++)
			{
				if (i==0)
					Actions.Enqueue(Intermediary[i]);
				else
					Parameters.Enqueue(Intermediary[i]);
			}
		}
		/// <summary>
		/// Returns 0 if not an action, otherwise, the number of parameters that action takes.
		/// </summary>
		public int isAction(string Input)
		{
			if(Input.Equals("spacify") || Input.Equals("capitalize") || Input.Equals("underscores") || 
				Input.Equals("prepend") || Input.Equals("append"))
			{
				return 1;
			}
			if(Input.Equals("delete"))
			{
				return 2;
			}
			return 0;
		}
		public void ProcessRuleset()
		{
			RefreshFileIndex();
			while(Actions.Count != 0)
			{
				string NextAction = Actions.Dequeue().ToString();
				if(NextAction.Equals("prepend"))
				{
					DoPrepend();
				}
				if(NextAction.Equals("append"))
				{
					DoAppend();
				}
				if(NextAction.Equals("spacify"))
				{
					DoSpacify();
				}
				if(NextAction.Equals("capitalize"))
				{
					DoCapitalize();
				}
				if(NextAction.Equals("delete"))
				{
					DoDelete();
				}
				if(NextAction.Equals("underscores"))
				{
					DoUnderscores();
				}
			}
			RefreshFileIndex();
		}
		public void DoUnderscores()
		{
			string UnderscoreStatus = Parameters.Dequeue().ToString();
			foreach(string NextFullPath in Files)
			{
				string NextFile = Path.GetFileNameWithoutExtension(NextFullPath);
				string NewFile;
				if(UnderscoreStatus.Equals("off"))
					NewFile = System.Text.RegularExpressions.Regex.Replace(NextFile,"_"," ");
				else
					NewFile = System.Text.RegularExpressions.Regex.Replace(NextFile," ","_");
				string Answer = Path.Combine(Path.GetDirectoryName(NextFullPath),NewFile)+Path.GetExtension(NextFullPath);
				File.Move(NextFullPath,Answer);
			}
			RefreshFileIndex();
		}
		public void DoPrepend()
		{
			string Additive = Parameters.Dequeue().ToString();
			foreach(string NextFullPath in Files)
			{
				string NextFile = Path.GetFileNameWithoutExtension(NextFullPath);
				string NewFile = Additive + NextFile;
				string Answer = Path.Combine(Path.GetDirectoryName(NextFullPath),NewFile)+Path.GetExtension(NextFullPath);
				File.Move(NextFullPath,Answer);
			}
			RefreshFileIndex();
		}
		public void DoAppend()
		{
			string Additive = Parameters.Dequeue().ToString();
			foreach(string NextFullPath in Files)
			{
				string NextFile = Path.GetFileNameWithoutExtension(NextFullPath);
				string NewFile = NextFile + Additive;
				string Answer = Path.Combine(Path.GetDirectoryName(NextFullPath),NewFile)+Path.GetExtension(NextFullPath);
				File.Move(NextFullPath,Answer);
			}
			RefreshFileIndex();
		}
		public void DoDelete()
		{
			string Location = Parameters.Dequeue().ToString();
			int NumChars = Int32.Parse(Parameters.Dequeue().ToString());
			foreach(string NextFullPath in Files)
			{
				string NextFile = Path.GetFileNameWithoutExtension(NextFullPath);
				string NewFile;
				if(Location.Equals("first"))
					NewFile = NextFile.Substring(NumChars,NextFile.Length-NumChars);
				else
					NewFile = NextFile.Substring(0,NextFile.Length-NumChars);
				string Answer = Path.Combine(Path.GetDirectoryName(NextFullPath),NewFile)+Path.GetExtension(NextFullPath);
				File.Move(NextFullPath,Answer);
			}
			RefreshFileIndex();
		}
		public void DoSpacify()
		{
			string SpacifiedChar = Parameters.Dequeue().ToString();
			foreach(string NextFullPath in Files)
			{
				string NextFile = Path.GetFileNameWithoutExtension(NextFullPath);
				string NewFile = System.Text.RegularExpressions.Regex.Replace(NextFile,SpacifiedChar," " + SpacifiedChar + " ");
				string Answer = Path.Combine(Path.GetDirectoryName(NextFullPath),NewFile)+Path.GetExtension(NextFullPath);
				File.Move(NextFullPath,Answer);
			}
			RefreshFileIndex();
		}
		public void DoCapitalize()
		{
			Parameters.Dequeue();
			foreach(string NextFullPath in Files)
			{
				string NextFile = Path.GetFileNameWithoutExtension(NextFullPath);
				bool NewWord = true;
				string NewFile = "";
				for(int i=0;i<NextFile.Length;i++)
				{
					char NextChar = ' ';
					if(char.IsLetterOrDigit(NextFile[i]) && NewWord)
					{
						NewWord = false;
						NextChar = char.IsLetter(NextFile[i])?char.ToUpper(NextFile[i]):NextFile[i];
					}
					else if(!char.IsLetterOrDigit(NextFile[i]))
					{
						NewWord = true;
						NextChar = NextFile[i];
					}
					else
					{
						NextChar = NextFile[i];
					}
					NewFile += NextChar;
				}
				string Answer = Path.Combine(Path.GetDirectoryName(NextFullPath),NewFile)+Path.GetExtension(NextFullPath);
				File.Move(NextFullPath,Answer);
			}
			RefreshFileIndex();
		}
		public void SetRootFolder(string NewRoot, string Filter)
		{
			Files = Directory.GetFiles(NewRoot,Filter);
			Environment.CurrentDirectory = NewRoot;
		}
		private void RefreshFileIndex()
		{
			Files = Directory.GetFiles(Environment.CurrentDirectory);
		}
	}
}