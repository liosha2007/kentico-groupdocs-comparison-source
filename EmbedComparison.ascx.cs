using System;
using CMS.PortalControls;

public partial class CMSWebParts_Groupdocs_EmbedComparison : CMSAbstractWebPart
{
    protected void Page_Load(object sender, EventArgs e)
    {
        iframe.Attributes.Add("src", String.Format("http://apps.groupdocs.com/document-comparison/embed/{0}/{1}?referer=Kentico/1.0", GetValue("EmbedKey"), GetValue("Guid")));
        iframe.Attributes.Add("width", GetValue("FrameWidth").ToString());
        iframe.Attributes.Add("height", GetValue("FrameHeight").ToString());
    }
}