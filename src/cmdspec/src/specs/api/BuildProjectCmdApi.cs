//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [ApiHost]
    public static class BuildProjectCmdApi
    {
        [Op]
        static void render(in BuildProjectCmd src, ITextBuffer dst)
        {
            dst.Append("dotnet build");

            dst.AppendSpace();
            dst.Append(src.SolutionPath.Format(PathSeparator.BS));

            dst.AppendSpace();
            dst.AppendFormat(PropertySpec, nameof(src.Configuration), src.Configuration);

            dst.AppendSpace();
            dst.AppendFormat(QuotedPropertySpec, nameof(src.Platform), src.Platform);

            if(src.LogFile.IsNonEmpty)
            {
                dst.AppendSpace();
                dst.AppendFormat(Flag, "fl");
                dst.AppendSpace();
                dst.AppendFormat(QuotedOptionAssign, "flp", nameof(src.LogFile), src.LogFile.Format(PathSeparator.BS));
                if(src.Verbosity != 0)
                    dst.AppendFormat(";{0}={1} ","verbosity", src.Verbosity);

            }

            if(src.MaxCpuCount != 0)
            {
                dst.AppendSpace();
                dst.AppendFormat(OptionValue, nameof(src.MaxCpuCount), src.MaxCpuCount);
            }

            if(src.Graph)
            {
                dst.AppendSpace();
                dst.AppendFormat(OptionValue, "graph", src.Graph);
            }

        }

        [Op]
        public static string Format(this BuildProjectCmd src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }

        [Op]
        static FS.FilePath ProjectPath(this CmdBuilder src, in BuildCmdVars vars)
            => src.Env.DevRoot + FS.folder("src") + FS.folder(vars.ProjectId) + FS.file(string.Format("z0.{0}", vars.ProjectId), FileExtensions.CsProj);

        [Op]
        static FS.FilePath SolutionPath(this CmdBuilder src, in BuildCmdVars vars)
            => src.Env.DevRoot + FS.file(string.Format("z0.{0}", vars.SlnId), FileExtensions.Sln);

        [Op]
        static FS.FilePath LogPath(this CmdBuilder src, in BuildCmdVars vars)
            => src.Db.BuildLogPath(FS.file(string.Format("z0.{0}", vars.ProjectId), FileExtensions.Log));


        [Op]
        public static string Identifier(this BuildProjectCmd src)
            => string.Format("{0}_{1}",
                BuildProjectCmd.CmdName,
                src.SolutionPath.IsNonEmpty ? src.SolutionPath.FileName.Format() : src.ProjectPath.FileName.Format());

        [Op]
        public static Outcome<FS.FilePath> Save(this BuildProjectCmd src, FS.FolderPath dst)
        {
            var path = dst + FS.file(src.Identifier(), FileExtensions.Cmd);
            var result = path.Save(src.Format());
            if(result)
                return path;
            else
                return result;
        }

        [Op]
        public static BuildProjectCmd Build(this CmdBuilder src, BuildCmdVars vars)
        {
            var dst = new BuildProjectCmd();
            dst.Verbosity = BuildLogVerbosity.detailed;
            dst.Platform = "Any Cpu";
            dst.Configuration = "Release";
            dst.Graph = true;
            dst.MaxCpuCount = 6;
            dst.LogFile = src.LogPath(vars);
            dst.ProjectPath = src.ProjectPath(vars);
            dst.SolutionPath = src.SolutionPath(vars);
            return dst;
        }

        [Op]
        public static BuildProjectCmd Build(this CmdBuilder src)
        {
            var vars = new BuildCmdVars();
            vars.ProjectId = PartId.Machine.Format();
            vars.SlnId = PartId.Machine.Format();
            return src.Build(vars);
        }

        const string Quote = "\"";

        const string PropertySpec = "/p:{0}={1}";

        const string Flag = "-{0}";

        const string OptionValue = "-{0}:{1}";

        const string OptionAssign ="-{0}:{1}={2}";

        const string QuotedOptionAssign ="-{0}:{1}=" + QuotedFence2;

        const string QuotedFence = Quote + "{0}" + Quote;

        const string QuotedFence1 = Quote + "{1}" + Quote;

        const string QuotedFence2 = Quote + "{2}" + Quote;

        const string QuotedFence3 = Quote + "{3}" + Quote;

        const string QuotedPropertySpec = "/p:{0}=" + QuotedFence1;
    }
}