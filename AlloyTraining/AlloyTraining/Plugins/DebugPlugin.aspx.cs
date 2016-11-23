using System;

namespace AlloyTraining.Plugins
{
    [EPiServer.Shell.ViewComposition.IFrameComponent(
        Url = "~/Plugins/DebugPlugin.aspx",
        ReloadOnContextChange = true,
        PlugInAreas = EPiServer.Shell.PlugInArea.Assets,
        Title = "Property debugger",
        Categories = "CMS",
        MinHeight = 200,
        MaxHeight = 700)]
    public partial class DebugPlugin : EPiServer.Shell.WebForms.ContentWebFormsBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string output = "<table>";
            foreach (var prop in CurrentContent.Property)
            {
                output += "<tr><td>" + prop.Name + "</td><td>" + prop.Value + "</td></tr>";
            }
            output += "</table>";
            LitCtrl.Text = output;
        }
    }
}