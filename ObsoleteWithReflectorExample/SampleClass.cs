namespace ObsoleteWithReflectorExample;

[Obsolete("Цей плас застарілий")]
public class SampleClass
{
    [Obsolete("Це поле застаріле")]
    public string OldField;

    public string NewField;
    
    [Obsolete("Цей метод застарілий")]
    public void OldMethod() { }

    public void NewMethod() { }
}