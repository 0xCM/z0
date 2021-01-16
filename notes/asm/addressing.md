# Addressing modes

Taken from <https://cs61.seas.harvard.edu/site/2018/Asm1/>

NOTE: ATT syntax used

| Type      | Example syntax    | Value used                                       |
| Register  | %rbp              | Contents of %rbp                                 |
| Immediate | $0x4              | 0x4                                              |
| Memory    | 0x4               | Value stored at address                          |
|           | symbol_name       | Value stored in global symbol_name               |
|           | symbol_name(%rip) | %rip -relative addressing for global (see below) |
|           | (%rax)            | Value stored at address in %rax                  |
|           | 0x4(%rax)         | Value stored at address %rax + 4                 |
|           | (%rax,%rbx)       | Value stored at address %rax + %rbx              |
|           | (%rax,%rbx,4)     | Value stored at address %rax + %rbx*4            |
|           | 0x18(%rax,%rbx,4) | Value stored at address %rax + 0x18 + %rbx*4     |

The full form of a memory operand is offset(base,index,scale), which refers to the  address offset + base + index*scale.

Example: 0x18(%rax,%rbx,4)
| %rax | base   |
| 0x18 | offset |
| %rbx | index  |
| 4    | scale  |

The offset (if used) must be a constant and the base (if used) must be a register; the scale must be either 1, 2, 4, or 8. The default offset, base, and index are 0, and the default scale is 1.