// Pokémon Duodecuple Distribution
// by Prof. 9
// Version 1.4.1 "Skinless"
// With Edits by Regnum for PKMG5DC
// Thanks to Yellow Wood Goblin for the slot-1 read fix.

.include options.asm

.nds
.open arm7.bin,2380000h

.org	23A6370h
loadhijack:
	push	r5,r14
	bl	2007F98h
	ldr	r0,=2013900h
	ldr	r1,=2030000h
	ldrb	r1,[r1]
	mov	r1,r1,lsl 3h
	ldr	r2,[r0,r1]
	ldr	r1,=2011628h
	ldr	r3,=16D0h
	bl	2003874h

	mov	r5,0h
fixchecksum:
	mov	r2,2D0h
	mul	r2,r5
	ldr	r1,=201162Ch
	add	r1,r1,r2
	ldr	r2,=2CEh
	ldr	r0,=27E3558h
	bl	2007318h
	ldr	r1,=20118FAh
	mov	r2,2D0h
	mul	r2,r5
	strh	r0,[r1,r2]
	add	r5,r5,1h
	cmp	r5,7h
	blt	fixchecksum

loadhijackexit:
	mov	r0,r4
	pop	r5,r15

buttonhijack:
	push	r14
	ldr	r1,=2030000h
	ldrb	r2,[r1]
	ldrh	r0,[r0]
	tst	r0,40h
	beq	downtest
	cmp	r2,0h
.ifdef amount
	moveq	r2,amount-1h
.else
	moveq	r2,0Bh
.endif
	subne	r2,1h
	b	bhdo

downtest:
	tst	r0,80h
	beq	bhexit
.ifdef amount
	cmp	r2,amount-1h
.else
	cmp	r2,0Bh
.endif
	moveq	r2,0h
	addne	r2,1h

bhdo:
	strh	r2,[r1]
	bl	displayroutine
	bic	r0,r0,1h

bhexit:
	pop	r15

displayhijack:
	push	r14
	bl	displayroutine
	bl	2000C94h
	pop	r15

displayroutine:
	push	r0-r7,r14
	bl	2007F98h
	ldr	r1,=2030000h
	ldr	r0,[r1,4h]
	cmp	r0,0h
	bne	skiploading
	str	r0,[r1]
	add	r1,4h

loadlanguage:
	ldr	r0,=languagepool
	ldr	r5,=27FFCE4h
	ldrb	r5,[r5]
	cmp	r5,6h
	bge	setenglish
	ldrb	r5,[r0,r5]
	b	loadnext

setenglish:
	mov	r5,0h

loadnext:
	mov	r0,2D0h
	mul	r5,r5,r0
	mov	r4,0h
	ldr	r6,=2013900h
	mov	r3,4Ah

loadloop:
	ldr	r2,[r6,r4]
	add	r2,r2,r5
	add	r2,r2,64h
	push	r0,r1,r2
	bl	2003874h
	pop	r0,r1,r2
	add	r1,4Ah

	add	r4,8h
.ifdef amount
	cmp	r4,amount*8h
.else
	cmp	r4,60h
.endif
	blt	loadloop

clean:
	ldr	r0,=2030004h
	ldr	r1,=0FFFFh
	mov	r2,0h

cleanloop:
	ldrh	r3,[r0,r2]
	cmp	r3,r1
	bne	cleannext
	mov	r3,0h
	strh	r3,[r0,r2]

cleannext:
	add	r2,2h
	ldr	r3,=428h
	cmp	r2,r3
	blt	cleanloop

skiploading:
	ldr	r5,=2030004h
.ifdef mypos
	mov	r6,mypos
.else
	mov	r6,0h
.endif
	mov	r7,0h

displayloop:
	bl	2006E04h	// r0-r3
	str	r5,[r13]
	ldr	r3,=2030000h
	ldrb	r3,[r3]
	cmp	r3,r7
.ifdef select
	ldreq	r3,=select|8000h
.else
	ldreq	r3,=801Fh
.endif
.ifdef menu
	ldrne	r3,=menu|8000h
.else
	ldrne	r3,=0FFFFh
.endif
.ifdef mxpos
	mov	r1,mxpos
.else
	mov	r1,80h
.endif
	mov	r2,r6
	mov	r4,0h
	str	r4,[r13,4h]
	bl	2002D70h	// r0-r2

	add	r5,4Ah
.ifdef dist
	add	r6,dist
.else
	add	r6,0Ch
.endif
	add	r7,1h
.ifdef amount
	cmp	r7,amount
.else
	cmp	r7,0Ch
.endif
	blt	displayloop

exit:
	pop	r0-r7,r15
.pool
languagepool:
	dcb	0x05,0x00,0x01,0x03,0x02,0x04
.close

.open arm9.bin,2000000h

.org 2000DECh
	mov r0,1h
	add r13,r13,10h
	pop r4,r15

.org 20011F0h
	bl	displayhijack

.org 2001200h
.ifdef d1xpos
	mov	r5,d1xpos
.else
	mov	r5,80h
.endif

.org 200121Ch
.ifdef d1ypos
	mov	r4,d1ypos
.else
	mov	r4,9Ch
.endif

.org 2001244h
.ifdef d1ypos
	mov	r4,d1ypos
.else
	mov	r4,9Ch
.endif

.org 2001260h
.ifdef d1xpos
	mov	r6,d1xpos
.else
	mov	r6,80h
.endif

.org 200127Ch
.ifdef d1ypos
	mov	r2,d1ypos
.else
	mov	r2,9Ch
.endif

.org 2001294h
.ifdef d2xpos
	mov	r1,d2xpos
.else
	mov	r1,80h
.endif

.org 200129Ch
.ifdef d2ypos
	mov	r2,d2ypos
.else
	mov	r2,0B4h
.endif

.org 20012C4h
.ifdef d1ypos
	mov	r2,d1ypos
.else
	mov	r2,9Ch
.endif

.org 20012D8h
.ifdef d2xpos
	mov	r1,d2xpos
.else
	mov	r1,80h
.endif

.org 20012E4h
.ifdef d2ypos
	mov	r2,d2ypos
.else
	mov	r2,0B4h
.endif

.org 20012FCh
.ifdef text
	dcd	text|8000h
.else
	dcd	0FFFFh
.endif

.org 2001500h
	bl	buttonhijack

.org 200150Ch
	bl	loadhijack

.org 2002E5Ch
.ifdef mode
	.if mode==0
		mov	r7,r7
	.elseif mode==2
		sub	r7,r7,r0
	.endif
.endif

.org 200E9BCh
	dcb 0x30,0x31,0x2E,0x62,0x69,0x6E,0x00,0x00,0x00	// 01.bin

.close