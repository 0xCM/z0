#define TARGET_AMD64 1
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
#include "runtime/corhdr.h"
#include "runtime/cor.h"
#include "runtime/cordebuginfo.h"
#include "runtime/readytorun.h"
