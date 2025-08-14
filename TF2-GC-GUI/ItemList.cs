using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TF2_GC_GUI
{
    public class Tf2Item
    {
        public int Defindex { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{Defindex}: {Name}";
    }
    public class ItemList
    {
        public static List<Tf2Item> LoadItems(string filePath)
        {
            var items = new List<Tf2Item>();

            foreach (var line in File.ReadLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(' ', 2);
                if (parts.Length != 2) continue;

                if (int.TryParse(parts[0], out int defindex))
                {
                    items.Add(new Tf2Item
                    {
                        Defindex = defindex,
                        Name = parts[1].Trim()
                    });
                }
            }

            return items;
        }
        public static void AddNewInventoryEntry(string filePath, int defIndex)
        {
            int lastId = GetLastEntryIdByBrace(filePath);
            int newId = lastId + 1;

            // this is the block thats inserted into the text file
            string newEntry = $@"
	""{newId}""
	{{
    		""def_index""		""{defIndex}""
	}}";

            File.AppendAllText(filePath, newEntry);
        }
        public static int GetLastEntryIdByBrace(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            int lastEntryId = -1;

            for (int i = lines.Length - 1; i >= 1; i--)
            {
                string line = lines[i].Trim();
                string prevLine = lines[i - 1].Trim();

                if (line == "{" && prevLine.StartsWith("\"") && prevLine.EndsWith("\""))
                {
                    string insideQuotes = prevLine.Trim('"');
                    if (int.TryParse(insideQuotes, out int id))
                    {
                        if (id > lastEntryId)
                            lastEntryId = id;
                    }
                }
            }
            return lastEntryId;
        }

    }
}


