class RcpParam
{
    public string ParamName { get; set; }
    public string ParamType { get; set; }
    public string Desc { get; set; }
    public IEnumerable<string> SupportedObects {get;set;}
    public Dictionary<string, object> TypesJson {get;set;}
    public string ParamTypeFull { get; internal set; }
}