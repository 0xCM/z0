import * as z0 from "./Tools"

declare let ildasm: "./ildasm"
export default ildasm;

export let ToolId:z0.ToolId = "ildasm"

export enum Examples {
    Example1 = "ildasm /tokens /bytes source.exe /out=target.il"
}

export enum Meanings {
    BYTES =             'Show actual bytes (in hex) as instruction comments.',
    CAVERBAL =          'Output CA blobs in verbal form (default - in binary form).',
    CLASSLIST =         'Include list of classes defined in the module.',
    CSV =               'Show the record counts and heap sizes.',
    FORWARD =           'Use forward class declaration.',
    HEADERS =           'Include file headers information in the output.',
    HEX  =              'Show more things in hex as well as words.',
    HEAPS =             'Show the raw heaps.',
    HTML =              'Output in HTML format (valid with /OUT option only).',
    ITEM =              'Disassemble the specified item only',
    LINENUM =           'Include references to original source lines.',
    MDHEADER =          'Show MetaData header information and sizes.',
    NOCA =              'Suppress output of custom attributes.',
    NOIL =              'Suppress IL assembler code output.',
    OUT =               'Direct output to file rather than to console.',
    PROJECT =           'Display .NET projection view if input is a .winmd file.',
    PUBONLY  =          'Only disassemble the public items (same as /VIS=PUB).',
    QUOTEALLNAMES =     'Include all names into single quotes.',
    RAW  =              'Show the raw MetaData tables.',
    RAWEH =             'Show exception handling clauses in raw form.',
    RTF =               'Output in rich text format (valid with /OUT option only).',
    SCHEMA =            'Show the MetaData header and schema information.',
    SOURCE =            'Show original source lines as comments.',
    STATS =             'Include statistics on the image.',
    TOKENS =            'Show metadata tokens of classes and members.',
    TYPELIST =          'Output full list of types (to preserve type ordering in round-trip).',
    UNREX =             'Show unresolved externals.',
    VALIDATE =          'Validate the consistency of the metadata.',
    VISIBILITY =        'Only disassemble the items with specified visibility.',
    UTF8 =              'Use UTF-8 encoding for output (default - ANSI).',
    UNICODE =           'Use UNICODE encoding for output.',
    ALL =               'Combination of /HEADER,/BYTES,/STATS,/CLASSLIST,/TOKENS'
}

export enum MetaKind {
    'MDHEADER',
    'HEX',
    'CSV',
    'UNREX',
    'SCHEMA',
    'RAW',
    'HEAPS',
    'VALIDATE'
}

export enum VisKind {
    'PUB',
    'PRI',
    'FAM',
    'ASM',
    'FAA',
    'FOA',
    'PSC'
}

export enum OutputKind
{
    'HTML',
    'RTF'
}

export enum ModuleOption
{
    'UTF8',
    'UNICODE',
    'NOIL',
    'FORWARD',
    'TYPELIST',
    'PROJECT',
    'HEADERS',
    'ITEM',
    'STATS',
    'CLASSLIST',
    'ALL',
}

export enum LibOption
{
    'OBJECTFILE'
}

export enum OutputOption
{
    'BYTES',
    'RAWEH',
    'TOKENS',
    'SOURCE',
    'LINENUM',
    'VISIBILITY',
    'PUBONLY',
    'QUOTEALLNAMES',
    'NOCA',
    'CAVERBAL',
}

export type DllOption = ModuleOption;

export type ExeOption = ModuleOption;


export type ToolOption = OutputOption | LibOption | DllOption | ExeOption

export type OutputSpec = {
    OUT : z0.ToolTarget,
    Options? : OutputKind,
}

export type MetadataSpec = {
    METADATA : [MetaKind]
}
