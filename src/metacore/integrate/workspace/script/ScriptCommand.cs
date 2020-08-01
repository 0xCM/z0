//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text.RegularExpressions;

    using static z;
    using static Konst;

    /// <summary>
    /// Represents a command that can be executed via a script
    /// </summary>
    public class ScriptCommand
    {
        // static T @if<S,T>(S src, Func<S,T> f, Func<T> alt)
        //     where S : class
        //         => src is null ? alt() : f(src);
        static string appendl(string head, string tail)
            => head + Environment.NewLine + tail;

        public static Option<ScriptCommandInvocation> MatchInvocation(Seq<ScriptCommand> commands, string expression)
            => from command in Match(commands, expression)
            from invocation in PrepareInvocation(command)
            select invocation;

        public static Option<(ScriptCommand, string[])> Match(Seq<ScriptCommand> commands, string expression)
        {
            var regex = new Regex(@"(?<FunctionName>[a-zA-Z]{1}[a-zA-Z0-9_]*)\((?<ArgList>(.)*)\)");
            var m = regex.Match(expression);
            if (m.HasGroupValue("FunctionName"))
            {
                var functionName = m.GetGroupValue("FunctionName");
                var functionArgs = m.HasGroupValue("ArgList") && m.GetGroupValue("ArgList") != EmptyString
                                    ? m.GetGroupValue("ArgList").Split(',') : new string[0];

                var command = commands.FirstOrDefault(x => x.Name == functionName);
                if (command != null)
                    return Option.some((command, functionArgs));
            }
            else
            {
                var command = commands.FirstOrDefault(x => string.Compare(x.Name, expression) == 0);
                if (command != null)
                    return (command, sys.empty<string>());
            }

            return none<(ScriptCommand,string[])>();
        }

        static Option<object> ConvertArgValue(object srcValue, Type targetType)
        {
            try
            {
                if (targetType == typeof(Date) && srcValue != null)
                    return Date.Parse($"{srcValue}");
                else
                    return Convert.ChangeType(srcValue, targetType);

            }
            catch (Exception e)
            {
                term.error(e);
                return none<object>();
            }
        }

        public static Option<ScriptCommandInvocation> PrepareInvocation((ScriptCommand, string[]) call)
        {
            var command = call.Item1;
            var args = call.Item2;
            var argConversions = list<object>();
            var parameters = map(command.Parameters, p => p.ClrParameter);

            if (parameters.Length == 1 && parameters[0].ParameterType.IsArray)
            {

                var elementType = parameters[0].ParameterType.GetElementType();
                var elementValues = list<object>();
                foreach(var srcValue in args)
                {

                    var dstValue = ConvertArgValue(srcValue, elementType)
                        .OnSome(elementValue => elementValues.Add(elementValue));
                    if (!dstValue)
                        return none<ScriptCommandInvocation>();
                }

                var elementCount = elementValues.Count;
                var dst = sys.alloc<object>(elementCount);
                for(int i=0; i< elementCount; i++)
                    dst[i] = elementValues[i];

                return new ScriptCommandInvocation(command, dst);
            }
            else
            {
                for (var i = 0; i < parameters.Length; i++)
                {
                    var dstType = parameters[i].ParameterType;
                    var srcValue = i < args.Length
                                    ? args[i].Replace("\"", EmptyString).Replace("'", EmptyString).Trim()
                                    : (parameters[i].HasDefaultValue ? parameters[i].DefaultValue : null);

                    var dstValue = ConvertArgValue(srcValue, dstType)
                        .OnSome(convertedValue => argConversions.Add(convertedValue));
                    if (!dstValue)
                        return none<ScriptCommandInvocation>();
                }
            }
            return new ScriptCommandInvocation(command, argConversions.Array());
        }

        public static Seq<ScriptCommand> Discover(params object[] hosts)
            => z.defer(from host in z.defer(hosts)
            from m in host.GetType().PublicInstanceMethods().Where(m => !m.IsGenericMethodDefinition)
            let mAttrib = m.GetCustomAttribute<ScriptCommandMethodAttribute>()
            select new ScriptCommand
            (
                Host: host,               
                ClrMethod: m,
                Description: @if(mAttrib, x => x.Description, () => EmptyString),
                CommandName: @if(mAttrib, attrib => text.ifblank(attrib.CommandName, m.Name), () => m.Name),
                IsProductionCommand: @if(mAttrib, x => x.IsProductionCommand, () => true),
                Parameters: from p in m.Parameters()
                            let pAttrib = p.GetCustomAttribute<ScriptCommandParameterAttribute>()
                            select new ScriptCommandParameter
                            (
                                ClrParameter: p,
                                Description: @if(pAttrib, x => x.Description, () => EmptyString),
                                ParameterName: @if(pAttrib, attrib => text.ifblank(attrib.ParameterName, p.Name), () => p.Name)
                            )
            ));

        public static Seq<ScriptCommand> Discover(params Type[] hosts)
            => z.defer(from host in z.defer(hosts)
                from m in host.PublicInstanceMethods().Where(m => !m.IsGenericMethodDefinition)
                let mAttrib = m.GetCustomAttribute<ScriptCommandMethodAttribute>()
                select new ScriptCommand
                (
                    ClrMethod: m,
                    Description: @if(mAttrib, x => x.Description, () => EmptyString),
                    CommandName: @if(mAttrib, attrib => text.ifblank(attrib.CommandName, m.Name), () => m.Name),
                    IsProductionCommand: @if(mAttrib, x => x.IsProductionCommand, () => true),
                    Parameters: 
                        from p in m.Parameters()
                        let pAttrib = p.GetCustomAttribute<ScriptCommandParameterAttribute>()
                        select new ScriptCommandParameter
                        (
                            ClrParameter: p,
                            Description: @if(pAttrib, x => x.Description, () => EmptyString),
                            ParameterName: @if(pAttrib, attrib => text.ifblank(attrib.ParameterName, p.Name), () => p.Name)
                        )
                ));

        public ScriptCommand(object Host, MethodInfo ClrMethod, string Description, string CommandName, bool IsProductionCommand, IEnumerable<ScriptCommandParameter> Parameters)
        {
            this.Host = Host;
            this.ClrMethod = ClrMethod;
            this.CommandName = CommandName;
            this.Description = Description;
            this.IsProductionCommand = IsProductionCommand;
            this.Parameters = Parameters.Array();
        }

        public ScriptCommand(Action CommandDelegate, string Name, string Description, bool IsProductionCommand = true)
        {
            this.CommandDelegate = CommandDelegate;
            this.CommandName = Name;
            this.Description = Description;
            this.IsProductionCommand = IsProductionCommand;
            this.Parameters = Parameters.Array();
        }

        public ScriptCommand(MethodInfo ClrMethod, string Description, string CommandName,  bool IsProductionCommand, IEnumerable<ScriptCommandParameter> Parameters
            )
        {
            this.ClrMethod = ClrMethod;
            this.CommandName = CommandName;
            this.Parameters = Parameters.Array();
            this.IsProductionCommand = IsProductionCommand;
            this.Description = Description;
        }

        object Host { get; }

        Action CommandDelegate { get; }

        MethodInfo ClrMethod { get; }

        string CommandName { get; }

        public string Description { get; }

        public bool IsProductionCommand { get; }

        public ScriptCommandParameter[] Parameters { get; }

        public string Name  
            => CommandName;

        public override string ToString()
        {
            var s = Name + $"({String.Join(",", Parameters.Select(x => x.ToString()))})";
            return text.blank(Description) ? s : appendl(s, "\t-" + Description);                
        }

        public Type HostType
            => ClrMethod.DeclaringType;

        public void Execute(object host, params object[] parameters)
        {
            if (Host != null)
            {
                var methodParms = ClrMethod.GetParameters();
                if (methodParms.Length == 1 && methodParms[0].ParameterType.IsArray)
                    ClrMethod.Invoke(Host, parameters.ToArray());
                else
                    ClrMethod.Invoke(Host, parameters);
                return;
            }

            if (ClrMethod != null)
                ClrMethod.Invoke(host, parameters);
            else
                CommandDelegate?.Invoke();
        }
    }

    partial class XTend
    {
        /// <summary>
        /// Determines whether a <see cref="Match"/> obtained via a regular expression contains a specified group
        /// </summary>
        /// <param name="m">The match</param>
        /// <param name="name">The candidate group name</param>
        public static bool HasGroupValue(this Match m, string name)
            => m.Groups[name].Success;

        /// <summary>
        /// Gets the value of a named match group if it exists; otherwise, throws an exception
        /// </summary>
        /// <param name="m">The matched expression</param>
        /// <param name="name">The name of the group</param>
        public static string GetGroupValue(this Match m, string name)
        {
            if (!m.Groups[name].Success)
                throw new ArgumentException($"The group {name} was not matched successfully");

            return m.Groups[name].Value;
        }

        /// <summary>
        /// Gets the value of an identified regular expression group
        /// </summary>
        /// <typeparam name="T">The group value type</typeparam>
        /// <param name="m">The matched expression</param>
        /// <param name="name">The name of the group</param>
        public static T GetGroupValue<T>(this Match m, string name)
        {
            var result = default(object);

            var groupValue = m.GetGroupValue(name);
            var valueType = typeof(T);
            if (valueType.IsString())
            {
                result = groupValue;
            }
            else if (valueType.IsNullableType())
            {
                result = Convert.ChangeType(groupValue, Nullable.GetUnderlyingType(valueType));
            }
            else
            {
                result = Convert.ChangeType(groupValue, valueType);
            }
            return (T)result;
        }
    }
}