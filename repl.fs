require run.fs

( create a buffer for the input )
1024 constant max-line
create temp-line max-line chars allot

( read up to max-line characters into the input buffer )
: read-from-stdin-line ( -- ptr n ) 
	temp-line max-line stdin read-line throw ( n flag )
	( if the flag is false then we are at eof )
	if 
	else 
		cr ." Exiting..." cr bye 
	then ( n )
	dup allocate throw ( n ptr2 )
	2dup ( n ptr2 n ptr2 )
	temp-line swap rot ( ptr1 ptr2 n )
	cmove swap ( ptr n )
;

: input-loop 
begin 
	." >>> " read-from-stdin-line ( ptr n )
	swap dup rot ( ptr ptr n )
	run ( ptr )
	free throw
again 
;

: runRepl ." Hello lox repl" cr input-loop ;
