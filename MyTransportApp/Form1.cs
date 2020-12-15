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
  public partial class Form1 : Form
  {

    ITransport transport = new Transport();
    Station station = new Station();

    public Form1()
    {
      InitializeComponent();
      ausgabeGrid.ForeColor = Color.Black;
    }

    private void sucheButton_Click(object sender, EventArgs e)
    {
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
      if (vonBox.Text != "" && nachBox.Text != "")
      {
        var connections = transport.GetConnections(vonBox.Text, nachBox.Text, 10);
        foreach(var connection in connections.ConnectionList)
        {
          ausgabeGrid.Rows.Add(new[] { 
            connection.From.Station.Name, 
            connection.To.Station.Name,
            connection.From.Platform , 
            connection.From.Departure.ToString(), 
            connection.To.Arrival.Value.ToString(), 
            connection.Duration });
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
        nachLable.Visible = false;
        nachBox.Visible = false;
        wechselnButton.Visible = false;
        titelLable.Text = "Abfahrtstafel";
        abfahrtstafelButton.Text = "Verbindungen suchen";
      }
      else
      {
        nachLable.Visible = true;
        nachBox.Visible = true;
        wechselnButton.Visible = true;
        titelLable.Text = "Verbindungen suchen";
        abfahrtstafelButton.Text = "Abfahrtstafel";
      }

    }
  }
}
