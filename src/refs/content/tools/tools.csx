using System;
using System.IO;
using System.Reflection;
using System.Text;

using api = ScriptVars;

using static Globals;

public struct Globals
{
    public static ScriptSymbol PathSep => '\\';
}

public interface IScriptVar
{
    ScriptSymbol Symbol {get;}

    ScriptVarValue Value {get;}
}

public interface IScriptVar<H> : IScriptVar
    where H : struct, IScriptVar<H>
{

}

public struct ScriptSymbol
{
    public string Name;

    public ScriptSymbol(string name)
        => Name = name;

    public ScriptSymbol(char name)
        => Name = name.ToString();

    public override string ToString()
        => string.Format("$({0})",Name ?? string.Empty);

    public static implicit operator ScriptSymbol(string name)
        => new ScriptSymbol(name);

    public static implicit operator ScriptSymbol(char name)
        => new ScriptSymbol(name);

    public static ScriptSymbol operator + (ScriptSymbol a, ScriptSymbol b)
        => api.combine(a,b);
}

public struct ScriptVarValue
{
    public string Content;

    public ScriptVarValue(string name)
        => Content = name;

    public bool IsEmpty
        => string.IsNullOrWhiteSpace(Content);

    public bool IsNonEmpty
        => !IsEmpty;

    public override string ToString()
        => Content ?? string.Empty;

    public static implicit operator ScriptVarValue(string content)
        => new ScriptVarValue(content);

    public static implicit operator string(ScriptVarValue src)
        => src.Content;

    public static ScriptVarValue Empty
        => new ScriptVarValue(string.Empty);
}

public struct ScriptVar : IScriptVar<ScriptVar>
{
    public ScriptSymbol Symbol {get;}

    public ScriptVarValue Value {get;}

    public ScriptVar(ScriptSymbol name, ScriptVarValue value)
    {
        Symbol = name;
        Value = value;
    }

    public override string ToString()
        => string.Format("{0}={1}",Symbol,Value);

    public static implicit operator ScriptVar((ScriptSymbol symbol, ScriptVarValue value) src)
        => new ScriptVar(src.symbol, src.value);
}

public struct DirVar : IScriptVar<ScriptVar>
{
    public ScriptSymbol Symbol {get;}

    public ScriptVarValue Value {get;}

    public DirVar(ScriptSymbol name, ScriptVarValue value)
    {
        Symbol = name;
        Value = value;
    }

    public static implicit operator DirVar((ScriptSymbol symbol, ScriptVarValue value) src)
        => new DirVar(src.symbol, src.value);

    public static implicit operator ScriptVar(DirVar src)
        => new DirVar(src.Symbol, src.Value);

    public static DirVar operator + (DirVar a, DirVar b)
        => api.combine(a,b);
}

public struct ScriptVars
{
    public static string format(ScriptVar src)
        => string.Format("{0}={1}",src.Symbol, src.Value);

    public static string format(IScriptVar src)
        => string.Format("{0}={1}",src.Symbol, src.Value);

    public static ScriptSymbol combine(ScriptSymbol a, ScriptSymbol b)
        => new ScriptSymbol(string.Format("{0}{1}", a, b));

    public static DirVar combine(DirVar a, DirVar b)
    {
        var symbol = a.Symbol + PathSep + b.Symbol;
        var value = Path.Combine(a.Value, b.Value);
        return (symbol,value);
    }

    const BindingFlags MemberSelector = BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly;

    public static IEnumerable<IScriptVar> members<T>(T set)
        where T : IScriptVarSet<T>, new()
            => typeof(T).GetProperties(MemberSelector).Select(x => (IScriptVar)x.GetValue(set));

    public static IScriptVarSet @default()
        => default(ScriptVarSet);

    public static string format(IScriptVarSet src)
    {
        var dst = new StringBuilder();
        foreach(var member in src.Members())
            dst.AppendLine(format(member));
        return dst.ToString();
    }

    public static void test()
    {
        Console.Write(format(@default()));
    }
}

public interface IScriptVarSet
{
    IEnumerable<IScriptVar> Members();
}

public interface IScriptVarSet<H> : IScriptVarSet
    where H : IScriptVarSet<H>, new()
{

}

public struct ScriptVarSet : IScriptVarSet<ScriptVarSet>
{
    public DirVar ZDev => (nameof(ZDev), Environment.GetEnvironmentVariable(nameof(ZDev)));

    public DirVar ZDb => (nameof(ZDb), Environment.GetEnvironmentVariable(nameof(ZDb)));

    public DirVar ZControl => (nameof(ZControl), Environment.GetEnvironmentVariable(nameof(ZControl)));

    public IEnumerable<IScriptVar> Members()
        => api.members(this);

    public string Format()
        => api.format(this);

    public override string ToString()
        => Format();
}

public struct ToolVars
{
    public static ScriptVar ToolInfoRoot => (nameof(ToolInfoRoot), "");
}