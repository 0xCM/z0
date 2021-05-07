//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft Corporation. All rights reserved.
// License     :  MIT
// Origin      : https://github.com/microsoft/CsWin32/src/ScrapeDocs/Program.cs
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.Json;
    using System.Text.RegularExpressions;
    using System.Threading;
    using YamlDotNet.RepresentationModel;

    using static MsDocs.SearchPatterns;

    partial struct MsDocs
    {
        internal class Processor
        {
            readonly string ContentBase;

            readonly string OutputPath;

            Processor(string src, string dst)
            {
                ContentBase = src;
                OutputPath = dst;
            }

            public static void run(FS.FolderPath src, FS.FilePath dst)
            {
                using var cts = new CancellationTokenSource();
                Console.CancelKeyPress += (s, e) =>
                {
                    term.inform("Canceling...");
                    cts.Cancel();
                    e.Cancel = true;
                };

                try
                {
                    new Processor(src.Name, dst.Name).Worker(cts.Token);
                }
                catch (OperationCanceledException ex)
                    when (ex.CancellationToken == cts.Token)
                {

                }
            }

            // Skip the NULL constant due to https://github.com/aaubry/YamlDotNet/issues/591.
            static bool IsYamlProblematicKey(string key)
                => string.Equals(key, "null", StringComparison.OrdinalIgnoreCase);

            int AnalyzeEnums(ConcurrentDictionary<YamlNode, YamlNode> results, ConcurrentDictionary<(string MethodName, string ParameterName, string HelpLink), DocEnum> parameterEnums, ConcurrentDictionary<(string MethodName, string ParameterName, string HelpLink), DocEnum> fieldEnums)
            {
                var uniqueEnums = new Dictionary<DocEnum, List<(string MethodOrStructName, string ParameterOrFieldName, string HelpLink, bool IsMethod)>>();
                var constantsDocs = new Dictionary<string, List<(string MethodOrStructName, string HelpLink, string Doc)>>();

                void Collect(ConcurrentDictionary<(string MethodName, string ParameterName, string HelpLink), DocEnum> enums, bool isMethod)
                {
                    foreach (var item in enums)
                    {
                        if (!uniqueEnums.TryGetValue(item.Value, out List<(string MethodName, string ParameterName, string HelpLink, bool IsMethod)>? list))
                        {
                            uniqueEnums.Add(item.Value, list = new());
                        }

                        list.Add((item.Key.MethodName, item.Key.ParameterName, item.Key.HelpLink, isMethod));

                        foreach (KeyValuePair<string, (ulong? Value, string? Doc)> enumValue in item.Value.Members)
                        {
                            if (enumValue.Value.Doc is object)
                            {
                                if (!constantsDocs.TryGetValue(enumValue.Key, out List<(string MethodName, string HelpLink, string Doc)>? values))
                                    constantsDocs.Add(enumValue.Key, values = new());

                                values.Add((item.Key.MethodName, item.Key.HelpLink, enumValue.Value.Doc));
                            }
                        }
                    }
                }

                Collect(parameterEnums, isMethod: true);
                Collect(fieldEnums, isMethod: false);

                foreach (var item in constantsDocs)
                {
                    var doc = item.Value[0].Doc;

                    // If the documentation varies across methods, just link to each document.
                    bool differenceDetected = false;
                    for (int i = 1; i < item.Value.Count; i++)
                    {
                        if (item.Value[i].Doc != doc)
                        {
                            differenceDetected = true;
                            break;
                        }
                    }

                    var docNode = new YamlMappingNode();
                    if (differenceDetected)
                        doc = "Documentation varies per use. Refer to each: " + string.Join(", ", item.Value.Select(v => @$"<see href=""{v.HelpLink}"">{v.MethodOrStructName}</see>")) + ".";
                    else
                    {
                        // Just point to any arbitrary method that documents it.
                        docNode.Add("HelpLink", item.Value[0].HelpLink);
                    }

                    docNode.Add("Description", doc);

                    if (!IsYamlProblematicKey(item.Key))
                        results.TryAdd(new YamlScalarNode(item.Key), docNode);
                }

                var enumDirectory = Path.GetDirectoryName(OutputPath) ?? throw new InvalidOperationException("Unable to determine where to write enums.");
                Directory.CreateDirectory(enumDirectory);
                using var enumsJsonStream = File.OpenWrite(Path.Combine(enumDirectory, "enums.json"));
                using var writer = new Utf8JsonWriter(enumsJsonStream, new JsonWriterOptions { Indented = true });
                writer.WriteStartArray();

                foreach (KeyValuePair<DocEnum, List<(string MethodName, string ParameterName, string HelpLink, bool IsMethod)>> item in uniqueEnums)
                {
                    writer.WriteStartObject();

                    if (item.Key.GetRecommendedName(item.Value) is string enumName)
                        writer.WriteString("name", enumName);

                    writer.WriteBoolean("flags", item.Key.IsFlags);

                    writer.WritePropertyName("members");
                    writer.WriteStartArray();
                    foreach(var member in item.Key.Members)
                    {
                        writer.WriteStartObject();
                        writer.WriteString("name", member.Key);
                        if(member.Value.Value is ulong value)
                            writer.WriteString("value", value.ToString(CultureInfo.InvariantCulture));

                        writer.WriteEndObject();
                    }

                    writer.WriteEndArray();

                    writer.WritePropertyName("uses");
                    writer.WriteStartArray();
                    foreach(var uses in item.Value)
                    {
                        writer.WriteStartObject();

                        int periodIndex = uses.MethodName.IndexOf('.', StringComparison.Ordinal);
                        string? iface = periodIndex >= 0 ? uses.MethodName.Substring(0, periodIndex) : null;
                        string name = periodIndex >= 0 ? uses.MethodName.Substring(periodIndex + 1) : uses.MethodName;

                        if (iface is string)
                            writer.WriteString("interface", iface);

                        writer.WriteString(uses.IsMethod ? "method" : "struct", name);
                        writer.WriteString(uses.IsMethod ? "parameter" : "field", uses.ParameterName);

                        writer.WriteEndObject();
                    }

                    writer.WriteEndArray();
                    writer.WriteEndObject();
                }

                writer.WriteEndArray();

                return constantsDocs.Count;
            }

            void Worker(CancellationToken cancellationToken)
            {
                term.inform("Enumerating documents to be parsed...");
                string[] paths = Directory.GetFiles(this.ContentBase, "??-*-*.md", SearchOption.AllDirectories);

                term.inform("Parsing documents...");
                var timer = Stopwatch.StartNew();
                var parsedNodes = from path in paths.AsParallel()
                                let result = this.ParseDocFile(path)
                                where result is not null
                                select (Path: path, result.Value.ApiName, result.Value.YamlNode, result.Value.EnumsByParameter, result.Value.EnumsByField);
                var results = new ConcurrentDictionary<YamlNode, YamlNode>();
                var parameterEnums = new ConcurrentDictionary<(string MethodName, string ParameterName, string HelpLink), DocEnum>();
                var fieldEnums = new ConcurrentDictionary<(string StructName, string FieldName, string HelpLink), DocEnum>();
                if (Debugger.IsAttached)
                {
                    parsedNodes = parsedNodes.WithDegreeOfParallelism(1); // improve debuggability
                }

                parsedNodes
                    .WithCancellation<(string Path, string ApiName, YamlNode YamlNode, IReadOnlyDictionary<string, DocEnum> EnumsByParameter, IReadOnlyDictionary<string, DocEnum> EnumsByField)>(cancellationToken)
                    .ForAll(result =>
                    {
                        results.TryAdd(new YamlScalarNode(result.ApiName), result.YamlNode);
                        foreach (var e in result.EnumsByParameter)
                        {
                            string helpLink = ((YamlScalarNode)result.YamlNode["HelpLink"]).Value!;
                            parameterEnums.TryAdd((result.ApiName, e.Key, helpLink), e.Value);
                        }

                        foreach (var e in result.EnumsByField)
                        {
                            string helpLink = ((YamlScalarNode)result.YamlNode["HelpLink"]).Value!;
                            fieldEnums.TryAdd((result.ApiName, e.Key, helpLink), e.Value);
                        }
                    });
                if (paths.Length == 0)
                {
                    term.error("No documents found to parse.");
                }
                else
                {
                    term.inform(string.Format("Parsed {2} documents in {0} ({1} per document)", timer.Elapsed, timer.Elapsed / paths.Length, paths.Length));
                    term.inform($"Found {parameterEnums.Count + fieldEnums.Count} enums.");
                }

                term.inform("Analyzing and naming enums and collecting docs on their members...");
                int constantsCount = AnalyzeEnums(results, parameterEnums, fieldEnums);
                term.inform($"Found docs for {constantsCount} constants.");

                term.inform(string.Format("Writing results to \"{0}\"", OutputPath));
                var yamlDocument = new YamlDocument(new YamlMappingNode(results));
                var yamlStream = new YamlStream(yamlDocument);
                Directory.CreateDirectory(Path.GetDirectoryName(OutputPath)!);
                using var yamlWriter = File.CreateText(this.OutputPath);
                yamlWriter.WriteLine($"# This file was generated by the {Assembly.GetExecutingAssembly().GetName().Name} tool in this repo.");
                yamlStream.Save(yamlWriter);
            }

            (string ApiName, YamlNode YamlNode, IReadOnlyDictionary<string, DocEnum> EnumsByParameter, IReadOnlyDictionary<string, DocEnum> EnumsByField)? ParseDocFile(string filePath)
            {
                try
                {
                    var enumsByParameter = new Dictionary<string, DocEnum>();
                    var enumsByField = new Dictionary<string, DocEnum>();
                    var yaml = new YamlStream();
                    using StreamReader mdFileReader = File.OpenText(filePath);
                    using var markdownToYamlReader = new YamlSectionReader(mdFileReader);
                    var yamlBuilder = new StringBuilder();
                    string? line;
                    while ((line = markdownToYamlReader.ReadLine()) is object)
                    {
                        yamlBuilder.AppendLine(line);
                    }

                    try
                    {
                        yaml.Load(new StringReader(yamlBuilder.ToString()));
                    }
                    catch (YamlDotNet.Core.YamlException ex)
                    {
                        Debug.WriteLine("YAML parsing error in \"{0}\": {1}", filePath, ex.Message);
                        return null;
                    }

                    YamlSequenceNode methodNames = (YamlSequenceNode)yaml.Documents[0].RootNode["api_name"];
                    bool TryGetProperName(string searchFor, string? suffix, [NotNullWhen(true)] out string? match)
                    {
                        if (suffix is string)
                        {
                            if (searchFor.EndsWith(suffix, StringComparison.Ordinal))
                            {
                                searchFor = searchFor.Substring(0, searchFor.Length - suffix.Length);
                            }
                            else
                            {
                                match = null;
                                return false;
                            }
                        }

                        match = methodNames.Children.Cast<YamlScalarNode>().FirstOrDefault(c => string.Equals(c.Value?.Replace('.', '-'), searchFor, StringComparison.OrdinalIgnoreCase))?.Value;

                        if (suffix is string && match is object)
                        {
                            match += suffix.ToUpper(CultureInfo.InvariantCulture);
                        }

                        return match is object;
                    }

                    string presumedMethodName = FileNamePattern.Match(Path.GetFileNameWithoutExtension(filePath)).Groups[1].Value;

                    // Some structures have filenames that include the W or A suffix when the content doesn't. So try some fuzzy matching.
                    if (!TryGetProperName(presumedMethodName, null, out string? properName) &&
                        !TryGetProperName(presumedMethodName, "a", out properName) &&
                        !TryGetProperName(presumedMethodName, "w", out properName) &&
                        !TryGetProperName(presumedMethodName, "32", out properName) &&
                        !TryGetProperName(presumedMethodName, "64", out properName))
                    {
                        Debug.WriteLine("WARNING: Could not find proper API name in: {0}", filePath);
                        return null;
                    }

                    var methodNode = new YamlMappingNode();
                    Uri helpLink = new Uri("https://docs.microsoft.com/windows/win32/api/" + filePath.Substring(this.ContentBase.Length, filePath.Length - 3 - this.ContentBase.Length).Replace('\\', '/'));
                    methodNode.Add("HelpLink", helpLink.AbsoluteUri);

                    var description = ((YamlMappingNode)yaml.Documents[0].RootNode).Children.FirstOrDefault(n => n.Key is YamlScalarNode { Value: "description" }).Value as YamlScalarNode;
                    if (description is object)
                    {
                        methodNode.Add("Description", description);
                    }

                    // Search for parameter/field docs
                    var parametersMap = new YamlMappingNode();
                    var fieldsMap = new YamlMappingNode();
                    YamlScalarNode? remarksNode = null;
                    StringBuilder docBuilder = new StringBuilder();
                    line = mdFileReader.ReadLine();

                    static string FixupLine(string line)
                    {
                        line = line.Replace("href=\"/", "href=\"https://docs.microsoft.com/");
                        line = InlineCodeTag.Replace(line, match => $"<c>{match.Groups[1].Value}</c>");
                        return line;
                    }

                    void ParseTextSection(out YamlScalarNode node)
                    {
                        while ((line = mdFileReader.ReadLine()) is object)
                        {
                            if (line.StartsWith('#'))
                                break;

                            line = FixupLine(line);
                            docBuilder.AppendLine(line);
                        }

                        node = new YamlScalarNode(docBuilder.ToString());

                        docBuilder.Clear();
                    }

                    IReadOnlyDictionary<string, (ulong? Value, string? Doc)> ParseEnumTable()
                    {
                        var enums = new Dictionary<string, (ulong? Value, string? Doc)>();
                        int state = 0;
                        const int StateReadingHeader = 0;
                        const int StateReadingName = 1;
                        const int StateLookingForDetail = 2;
                        const int StateReadingDocColumn = 3;
                        string? enumName = null;
                        ulong? enumValue = null;
                        var docsBuilder = new StringBuilder();
                        while ((line = mdFileReader.ReadLine()) is object)
                        {
                            if (line == "</table>")
                            {
                                break;
                            }

                            switch (state)
                            {
                                case StateReadingHeader:
                                    // Reading TR header
                                    if (line == "</tr>")
                                    {
                                        state = StateReadingName;
                                    }

                                    break;

                                case StateReadingName:
                                    // Reading an enum row's name column.
                                    Match m = EnumNameCell.Match(line);
                                    if (m.Success)
                                    {
                                        enumName = m.Groups[1].Value;
                                        if (enumName == "0")
                                        {
                                            enumName = "None";
                                            enumValue = 0;
                                        }

                                        state = StateLookingForDetail;
                                    }

                                    break;

                                case StateLookingForDetail:
                                    // Looking for an enum row's doc column.
                                    m = EnumOrdinalValue.Match(line);
                                    if (m.Success)
                                    {
                                        string value = m.Groups[1].Value;
                                        bool hex = value.StartsWith("0x", StringComparison.OrdinalIgnoreCase);
                                        if (hex)
                                        {
                                            value = value.Substring(2);
                                        }

                                        enumValue = ulong.Parse(value, hex ? NumberStyles.HexNumber : NumberStyles.Integer, CultureInfo.InvariantCulture);
                                    }
                                    else if (line.StartsWith("<td", StringComparison.OrdinalIgnoreCase))
                                    {
                                        state = StateReadingDocColumn;
                                    }
                                    else if (line.Contains("</tr>", StringComparison.OrdinalIgnoreCase))
                                    {
                                        // The row ended before we found the doc column.
                                        state = StateReadingName;
                                        enums.Add(enumName!, (enumValue, null));
                                        enumName = null;
                                        enumValue = null;
                                    }

                                    break;

                                case StateReadingDocColumn:
                                    // Reading the enum row's doc column.
                                    if (line.StartsWith("</td>", StringComparison.OrdinalIgnoreCase))
                                    {
                                        state = StateReadingName;

                                        // Some docs are invalid in documenting the same enum multiple times.
                                        if (!enums.ContainsKey(enumName!))
                                        {
                                            enums.Add(enumName!, (enumValue, docsBuilder.ToString().Trim()));
                                        }

                                        enumName = null;
                                        enumValue = null;
                                        docsBuilder.Clear();
                                        break;
                                    }

                                    docsBuilder.AppendLine(FixupLine(line));
                                    break;
                            }
                        }

                        return enums;
                    }

                    void ParseSection(Match match, YamlMappingNode receivingMap, bool lookForParameterEnums = false, bool lookForFieldEnums = false)
                    {
                        string sectionName = match.Groups[1].Value;
                        bool foundEnum = false;
                        bool foundEnumIsFlags = false;
                        while ((line = mdFileReader.ReadLine()) is object)
                        {
                            if (line.StartsWith('#'))
                            {
                                break;
                            }

                            if (lookForParameterEnums || lookForFieldEnums)
                            {
                                if (foundEnum)
                                {
                                    if (line == "<table>")
                                    {
                                        IReadOnlyDictionary<string, (ulong? Value, string? Doc)> enumNamesAndDocs = ParseEnumTable();
                                        if (enumNamesAndDocs.Count > 0)
                                        {
                                            var enums = lookForParameterEnums ? enumsByParameter : enumsByField;
                                            if (!enums.ContainsKey(sectionName))
                                            {
                                                enums.Add(sectionName, new DocEnum(foundEnumIsFlags, enumNamesAndDocs));
                                            }
                                        }

                                        lookForParameterEnums = false;
                                        lookForFieldEnums = false;
                                    }
                                }
                                else
                                {
                                    foundEnum = line.Contains("of the following values", StringComparison.OrdinalIgnoreCase);
                                    foundEnumIsFlags = line.Contains("combination of", StringComparison.OrdinalIgnoreCase)
                                        || line.Contains("zero or more of", StringComparison.OrdinalIgnoreCase)
                                        || line.Contains("one or both of", StringComparison.OrdinalIgnoreCase)
                                        || line.Contains("one or more of", StringComparison.OrdinalIgnoreCase);
                                }
                            }

                            if (!foundEnum)
                            {
                                line = FixupLine(line);
                                docBuilder.AppendLine(line);
                            }
                        }

                        try
                        {
                            if (!IsYamlProblematicKey(sectionName))
                            {
                                receivingMap.Add(sectionName, docBuilder.ToString().Trim());
                            }
                        }
                        catch (ArgumentException)
                        {
                        }

                        docBuilder.Clear();
                    }

                    while (line is object)
                    {
                        if (ParameterHeaderPattern.Match(line) is Match { Success: true } parameterMatch)
                        {
                            ParseSection(parameterMatch, parametersMap, lookForParameterEnums: true);
                        }
                        else if (FieldHeaderPattern.Match(line) is Match { Success: true } fieldMatch)
                        {
                            ParseSection(fieldMatch, fieldsMap, lookForFieldEnums: true);
                        }
                        else if (RemarksHeaderPattern.Match(line) is Match { Success: true } remarksMatch)
                        {
                            ParseTextSection(out remarksNode);
                        }
                        else
                        {
                            if (line is object && ReturnHeaderPattern.IsMatch(line))
                            {
                                break;
                            }

                            line = mdFileReader.ReadLine();
                        }
                    }

                    if (parametersMap.Any())
                    {
                        methodNode.Add("Parameters", parametersMap);
                    }

                    if (fieldsMap.Any())
                    {
                        methodNode.Add("Fields", fieldsMap);
                    }

                    if (remarksNode is object)
                    {
                        methodNode.Add("Remarks", remarksNode);
                    }

                    // Search for return value documentation
                    while (line is object)
                    {
                        Match m = ReturnHeaderPattern.Match(line);
                        if (m.Success)
                        {
                            while ((line = mdFileReader.ReadLine()) is object)
                            {
                                if (line.StartsWith('#'))
                                {
                                    break;
                                }

                                docBuilder.AppendLine(line);
                            }

                            methodNode.Add("ReturnValue", docBuilder.ToString().Trim());
                            docBuilder.Clear();
                            break;
                        }
                        else
                        {
                            line = mdFileReader.ReadLine();
                        }
                    }

                    return (properName, methodNode, enumsByParameter, enumsByField);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Failed parsing \"{filePath}\".", ex);
                }
            }
        }
    }
}