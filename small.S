	.file	"small.c"
#GCC for S+core 1.6 
	.text
	.align	2
	.globl	add
	.ent	add
add:
	.frame	r2,4,r3, 1		# vars= 0, regs= 1, args= 0, gp= 0
	.mask	0x00000004,-4
	sw	r2, [r0,-4]+
	mv!	r2, r0
	swp!	r4, 4
	swp!	r5, 8
	lwp!	r7, 4
	lwp!	r6, 8
	add	r6, r7, r6
	mv!	r4, r6
	mv!	r0, r2
	lw	r2, [r0]+, 4
	br!	r3
	.end	add
	.size	add, .-add
	.ident	"GCC: (GNU) 14.3.0"
