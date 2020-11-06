using static ApiNameParts;

[ApiNameProvider]
readonly struct ApiNames
{
    const string asm = nameof(asm);

    const string render = nameof(render);

    const string semantic = nameof(semantic);

    const string archive = nameof(archive);

    public const string AsmSemanticRender = asm + dot + semantic + dot + render;

    public const string AsmSemanticArchive = asm + dot + semantic + dot + archive;

    const string slots = nameof(slots);

    const string fx = nameof(fx);

    public const string FxSlots = fx + dot + slots;

    public const string n16 = nameof(n16);

    public const string u8 = nameof(u8);

    public const string x = nameof(x);

    public const string x8 = nameof(x8);

    public const string dot = ApiNameParts.dot;

    const string sep ="_";

    public const string FxSlots_n16x8x8x8 = fx + dot + slots + sep + n16 + x8 + x8 + x8;
}
