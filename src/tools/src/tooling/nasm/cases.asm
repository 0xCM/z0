bits 64

and_special:
and al, 033h                    ; (AND AL,imm8)<24 ib>
and ax, 03333h                  ; (AND AX,imm16)<25 iw>
and eax, 033333333h             ; (AND EAX,imm32)<25 id>
and rax, 033333333h             ; (AND RAX,imm32)<REX.W+ 25 id>
and_al_reg8:
and al, al                      ; (AND r/m8,imm8)<80 /4 ib>
and al, cl                      ; (AND r/m8,imm8)<80 /4 ib>
and al, dl                      ; (AND r/m8,imm8)<80 /4 ib>
and al, bl                      ; (AND r/m8,imm8)<80 /4 ib>
and al, spl                     ; (AND r/m8,imm8)<80 /4 ib>
and al, bpl                     ; (AND r/m8,imm8)<80 /4 ib>
and al, sil                     ; (AND r/m8,imm8)<80 /4 ib>
and al, dil                     ; (AND r/m8,imm8)<80 /4 ib>
and al, r8b                     ; (AND r/m8,imm8)<80 /4 ib>
and al, r9b                     ; (AND r/m8,imm8)<80 /4 ib>
and al, r10b                    ; (AND r/m8,imm8)<80 /4 ib>
and al, r11b                    ; (AND r/m8,imm8)<80 /4 ib>
and al, r12b                    ; (AND r/m8,imm8)<80 /4 ib>
and al, r13b                    ; (AND r/m8,imm8)<80 /4 ib>
and al, r14b                    ; (AND r/m8,imm8)<80 /4 ib>
and al, r15b                    ; (AND r/m8,imm8)<80 /4 ib>
and_cl_reg8:
and cl, al                      ; (AND r/m8,imm8)<80 /4 ib>
and cl, cl                      ; (AND r/m8,imm8)<80 /4 ib>
and cl, dl                      ; (AND r/m8,imm8)<80 /4 ib>
and cl, bl                      ; (AND r/m8,imm8)<80 /4 ib>
and cl, spl                     ; (AND r/m8,imm8)<80 /4 ib>
and cl, bpl                     ; (AND r/m8,imm8)<80 /4 ib>
and cl, sil                     ; (AND r/m8,imm8)<80 /4 ib>
and cl, dil                     ; (AND r/m8,imm8)<80 /4 ib>
and cl, r8b                     ; (AND r/m8,imm8)<80 /4 ib>
and cl, r9b                     ; (AND r/m8,imm8)<80 /4 ib>
and cl, r10b                    ; (AND r/m8,imm8)<80 /4 ib>
and cl, r11b                    ; (AND r/m8,imm8)<80 /4 ib>
and cl, r12b                    ; (AND r/m8,imm8)<80 /4 ib>
and cl, r13b                    ; (AND r/m8,imm8)<80 /4 ib>
and cl, r14b                    ; (AND r/m8,imm8)<80 /4 ib>
and cl, r15b                    ; (AND r/m8,imm8)<80 /4 ib>
and_r8b_reg8:
and r8b, al                      ; (AND r/m8,imm8)<80 /4 ib>
and r8b, cl                      ; (AND r/m8,imm8)<80 /4 ib>
and r8b, dl                      ; (AND r/m8,imm8)<80 /4 ib>
and r8b, bl                      ; (AND r/m8,imm8)<80 /4 ib>
and r8b, spl                     ; (AND r/m8,imm8)<80 /4 ib>
and r8b, bpl                     ; (AND r/m8,imm8)<80 /4 ib>
and r8b, sil                     ; (AND r/m8,imm8)<80 /4 ib>
and r8b, dil                     ; (AND r/m8,imm8)<80 /4 ib>
and r8b, r8b                     ; (AND r/m8,imm8)<80 /4 ib>
and r8b, r9b                     ; (AND r/m8,imm8)<80 /4 ib>
and r8b, r10b                    ; (AND r/m8,imm8)<80 /4 ib>
and r8b, r11b                    ; (AND r/m8,imm8)<80 /4 ib>
and r8b, r12b                    ; (AND r/m8,imm8)<80 /4 ib>
and r8b, r13b                    ; (AND r/m8,imm8)<80 /4 ib>
and r8b, r14b                    ; (AND r/m8,imm8)<80 /4 ib>
and r8b, r15b                    ; (AND r/m8,imm8)<80 /4 ib>