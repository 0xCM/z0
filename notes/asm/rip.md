# RIP Register Usage

Taken from <https://cs61.seas.harvard.edu/site/2018/Asm1/>

NOTE: ATT syntax used

## RIP-relative addressing

x86-64 code often refers to globals using %rip-relative addressing: a global variable named a is referenced as a(%rip) rather than a.

This style of reference supports position-independent code (PIC), a security feature. It specifically supports
position-independent executables (PIEs), which are programs that work independently of where their code is loaded into memory.

To run a conventional program, the operating system loads the program’s instructions into memory at a fixed address that’s the
same every time, then starts executing the program at its first instruction. This works great, and runs the program in
a predictable execution environment (the addresses of functions and global variables are the same every time). Unfortunately,
the very predictability of this environment makes the program easier to attack.

In a position-independent executable, the operating system loads the program at varying locations: every time it runs,
the program’s functions and global variables have different addresses. This makes the program harder to attack (though not impossible).

Program startup performance matters, so the operating system doesn’t recompile the program with different addresses each time.
Instead, the compiler does most of the work in advance by using relative addressing.

When the operating system loads a PIE, it picks a starting point and loads all instructions and globals relative to that starting point.
The PIE’s instructions never refer to global variables using direct addressing: you’ll never see movl global_int, %eax. Globals are
referenced relatively instead, using deltas relative to the next %rip: movl global_int(%rip), %eax.

These relative addresses work great independent of starting point! For instance, consider an instruction located at
(starting-point + 0x80) that loads a variable g located at (starting-point + 0x1000) into %rax. In a non-PIE, the instruction might be
written movq 0x400080, %rax (in compiler output, movq g, %rax); but this relies on g having a fixed address.
In a PIE, the instruction might be written movq 0xf80(%rip), %rax (in compiler output, movq g(%rip), %rax),
which works out beautifully no matter the starting point.

| If the starting point is… | The instruction is at… | g is at… | With delta… |
| 0x400000                  | 0x400080               | 0x401000 | 0xF80       |
| 0x404000                  | 0x404080               | 0x405000 | 0xF80       |
| 0x4003F0                  | 0x400470               | 0x4013F0 | 0xF80       |