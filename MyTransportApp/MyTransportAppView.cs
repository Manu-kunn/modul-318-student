using System;
using SwissTransport.Core;
using SwissTransport.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{ 
  public partial class MyTransportAppView : Form
  {
    ITransport transport = new Transport();
    Station station = new Station();

    public MyTransportAppView()
    {
      InitializeComponent();
      ausgabeGrid.ForeColor = Color.Black;
    }

    private void sucheButton_Click(object sender, EventArgs e)
    {
      ausgabeGrid.Rows.Clear();
      if (titelLable.Text == "Verbindungen suchen")
      {
        suchMode();
      }
      else
      {
        abfahrttafelMode();
      }
    }

    private void suchMode()
    {
      int anzahlVerbindungen = 0;
      if (vonBox.Text != "" && nachBox.Text != "")
      {
        var connections = transport.GetConnections(vonBox.Text, nachBox.Text, datumdp.Value, timedp.Value, 10);
        foreach (var connection in connections.ConnectionList)
        {
          ausgabeGrid.Rows.Add(new[] {
            connection.From.Station.Name,
            connection.To.Station.Name,
            connection.From.Platform ,
            connection.From.Departure.ToString(),
            connection.To.Arrival.Value.ToString(),
            connection.Duration });
          anzahlVerbindungen++;
        }
        if (anzahlVerbindungen == 0)
        {
          MessageBox.Show("Es wurden keine Verbindungen gefunden");
        }
      }
      else
      {
        MessageBox.Show("Fehlender Abfahrt-/Zielort");
      }
}

private void abfahrttafelMode()
{
  if (vonBox.Text != "")
  {
    DateTime zeit = DateTime.Now;
    var verbindungen = transport.GetStationBoard(vonBox.Text, "0", zeit, 10);
    foreach (var verbindung in verbindungen.Entries)
    {
      ausgabeGrid.Rows.Add(verbindungen.Station.Name, verbindung.To, verbindung.Name, verbindung.Stop.Departure);
    }
  }
  else
  {
    MessageBox.Show("Fehlender Abfahrt ort");
  }
}

private void abfahrtstafelButton_Click(object sender, EventArgs e)
{
  if (titelLable.Text == "Verbindungen suchen")
  {
    ausgabeGrid.Columns[2].HeaderText = "Zug-Name";
    ausgabeGrid.Columns[3].HeaderText = "Uhrzeit";
    ausgabeGrid.Columns[4].HeaderText = "-";
    ausgabeGrid.Columns[5].HeaderText = "-";
    nachBox.Enabled = false;
    wechselnButton.Enabled = false;
    datumdp.Enabled = false;
    timedp.Enabled = false;
    titelLable.Text = "Abfahrtstafel";
    abfahrtstafelButton.Text = "Verbindungen suchen";
  }
  else
  {
    ausgabeGrid.Columns[2].HeaderText = "Platform";
    ausgabeGrid.Columns[3].HeaderText = "Abfahrt";
    ausgabeGrid.Columns[4].HeaderText = "Ankunft";
    ausgabeGrid.Columns[5].HeaderText = "Dauer";
    nachBox.Enabled = true;
    wechselnButton.Enabled = true;
    datumdp.Enabled = true;
    timedp.Enabled = true;
    titelLable.Text = "Verbindungen suchen";
    abfahrtstafelButton.Text = "Abfahrtstafel";
  }

}

private void wechselnButton_Click(object sender, EventArgs e)
{
  string zwischenSpeicher = vonBox.Text;
  vonBox.Text = nachBox.Text;
  nachBox.Text = zwischenSpeicher;

}

private void vonBox_KeyUp(object sender, KeyEventArgs e)
{
  if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape)
  {
    var combobox = (ComboBox)sender;
    AutoCompletion.AddSuggestions(combobox);
  }
}

private void nachBox_KeyUp(object sender, KeyEventArgs e)
{
  if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape && e.KeyCode != Keys.Tab && e.KeyCode != Keys.Back)
  {
    var TextBox = (ComboBox)sender;
    AutoCompletion.AddSuggestions(TextBox);
  }
}
  }
}
