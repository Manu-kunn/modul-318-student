using SwissTransport;
using SwissTransport.Core;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyTransportApp
{
  public class AutoCompletion
  {
    private static Transport _transport = new Transport();
    public static void AddSuggestions(ComboBox TextBox)
    {
      try
      {
        List<string> temp = new List<string>();
        foreach (var station in _transport.GetStations(TextBox.Text).StationList)
        {
          temp.Add(station.Name);
        }
        if (temp.Count != 0 && temp.First() != null)
        {
          TextBox.Items.Clear();
          TextBox.Items.Add(TextBox.Text);  
          TextBox.Items.AddRange(temp.ToArray());
          if (TextBox.DroppedDown == false)
          {
            TextBox.DroppedDown = true;
          }
          TextBox.SelectionStart = TextBox.Text.Length;
        }
        else
        {
          TextBox.DroppedDown = false;
        }
      }
      catch
      {
        TextBox.Items.Clear();
        TextBox.Items.Add("Keine Treffer");
        if (TextBox.DroppedDown == false)
        {
          TextBox.DroppedDown = true;
        }
      }
    }
  }


}
