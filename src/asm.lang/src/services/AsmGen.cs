//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using T = AsmGenTarget;

    [ApiHost]
    public sealed partial class AsmGen : AppService<AsmGen>
    {
        const string InstructionContractName = nameof(ITypedInstruction);

        const string InlineAttributeSpec = "[MethodImpl(Inline)]";

        const string ApiCompleteAttribute = "[ApiComplete]";

        const string InlineOpAttributeSpec = "[MethodImpl(Inline), Op]";

        [Op]
        public void GenerateModelsInPlace(ReadOnlySpan<string> src)
        {
            var flow = Wf.Running();
            EmitInstructionContracts(GetTargetPath(T.InstructionContracts));
            EmitMonicExpressions(src, GetTargetPath(AsmGenTarget.MonicExpression));
            EmitMonicEnum(src, GetTargetPath(AsmGenTarget.MonicCodeEnum));
            EmitInstructionTypes(src,GetTargetPath(T.InstructionTypes));
            EmitStatementBuilder(src, GetTargetPath(T.StatementBuilder));
            Wf.Ran(flow);
        }

        [Op]
        public void GenerateModelsInPlace()
        {
            GenerateModelsInPlace(Wf.XedCatalog().MnemonicNames());
        }

        [Op]
        public void GenerateModels(ReadOnlySpan<string> src, FS.FolderPath dst)
        {
            var flow = Wf.Running();
            EmitInstructionContracts(GetTargetPath(T.InstructionContracts, dst));
            EmitMonicExpressions(src, GetTargetPath(AsmGenTarget.MonicExpression, dst));
            EmitMonicEnum(src, GetTargetPath(AsmGenTarget.MonicCodeEnum, dst));
            EmitInstructionTypes(src, GetTargetPath(T.InstructionTypes, dst));
            EmitStatementBuilder(src, GetTargetPath(T.StatementBuilder, dst));
            Wf.Ran(flow);
        }

        [Op]
        public void GenerateModels(FS.FolderPath dst)
        {
            GenerateModels(Wf.XedCatalog().MnemonicNames(), dst);
        }

        const byte Indent = 4;

        const string Open = "{";

        const string Close = "}";

        const string EnumDeclPattern = "public enum {0} : {1}";

        const string ReadOnlyStructDeclPattern = "public readonly struct {0}";

        const string MonicSymbolPattern = "[Symbol(\"{0}\")]";

        const string NamespaceUsingPattern = "using {0}";

        const string NamespaceDeclPattern = "namespace {0}";

        const string TargetNamespaceName = "Z0.Asm";

        const string MonicEnumType = "ushort";

        const string ZeroEnumMemberName = "None";


        const string StatementFactoryDefaultPattern = "public {0} {1}() => default;";

        const string ImplicitOperatorDeclPattern = "public static implicit operator {0}({1} src) => {2};";

        const string StatementFactoryArgPattern = "public {0} {1}(AsmHexCode encoded) => new {0}(encoded);";


        const string UsingCompilerServices = "using System.Runtime.CompilerServices;";

        const string UsingRoot = "using static Root;";

        const string UsingTypePattern = "using static {0};";

        const string ClassDeclPattern = "public class {0}";

        const string QualifiedAccessPattern = "{0}.{1}";

        const string AsmNamespaceDecl = "namespace Z0.Asm";

        const string ItemAssignPattern = "{0} = {1},";

        const string FieldDeclPattern = "public {0} {1};";

        const string InstructionContractPattern = @"namespace Z0.Asm
{
    public interface {TargetName}
    {
        AsmMnemonicCode Mnemonic {get;}

        AsmHexCode Encoded {get;}
    }

    public interface {TargetName}<T> : {TargetName}
        where T : struct, {TargetName}<T>
    {

    }
}";

    }
}