require run.fs

( create a buffer for the input )
1024 constant max-line
create temp-line max-line chars allot

( read up to max-line characters into the input buffer )
: read-from-stdin-line ( -- buffer n flag? ) 
	temp-line max-line stdin read-line throw ( n flag )
	( if the flag is false then we are at eof )
	if 
	else 
		cr ." Exiting..." cr bye 
	then ( n )
	temp-line swap ( ptr n )
;

: input-loop 
begin 
	." >>> " read-from-stdin-line ( ptr n )
	run
again 
;

: runRepl ." Hello lox repl" cr input-loop ;
