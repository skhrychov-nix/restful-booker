namespace restful_booker.Helpers;

public enum MediaType
{
    None,
    [System.ComponentModel.Description("application/json")]
    Json,
    [System.ComponentModel.Description("application/xml")]
    Xml,
    [System.ComponentModel.Description("text/plain")]
    PlainText
}