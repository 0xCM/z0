#define TARGET_AMD64 1
#define TARGET_WINDOWS 1
#define HOST_64BIT 1
#include <windows.h>
#include <winerror.h>
#include <ole2.h>                       // Definitions of OLE types.
#include <rpc.h>
#include <rpcndr.h>
#include <specstrings.h>
#include <winerror.h>
#include <windows.h>
#include <ole2.h>
#include <wchar.h>
#include <stdio.h>
#include <stdint.h>
#include <stdarg.h>
#include "DbgHelp.h"
//#include "cfi.h"
#include "cor.h"
#include "cordebuginfo.h"
#include "coredistools.h"
#include "corerror.h"
#include "corhdr.h"
#include "corinfo.h"
#include "corjit.h"
#include "corjithost.h"
#include "corprof.h"
#include "openum.h"
#include "gcinfotypes.h"
#include "daccess.h"


