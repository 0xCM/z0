# RIP register usage

Taken from <https://stackoverflow.com/questions/42215105/understanding-rip-register-in-intel-assembly>


Example for accessing locals relative to `rbp:

```armasm
push rbp                  ; save rbp
mov rbp,rsp               ; rbp = pointer to return address (8 bytes)
sub rsp,64                ; reserve 64 bytes for local variables
mov rax,[rbp+8]           ; rax = the last stack-passed qword parameter (if any)
mov rdx,[rbp]             ; rdx = return address
mov rcx,[rbp-8]           ; rcx = first qword local variable (this is undefined now)
mov r8, [rbp-16]          ; r8  = second qword local variable (this is undefined now)
.
.
mov rsp,rbp
pop rbp
ret
```

