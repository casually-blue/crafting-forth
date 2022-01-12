require run.fs

( create a buffer for the input )
1024 constant max-line
create temp-line max-line chars allot

( check if file read was successfull )
: read-check ( n flag ior -- n if? ) drop ;

( read up to max-line characters into the input buffer )
: read-from-stdin-line ( -- buffer n) temp-line max-line stdin read-line
read-check if 
	temp-line
else 
	0 = if 
		s"  " .s
	else
		." Error reading from stdin" cr bye 
	then
then ;

: input-loop begin 
	." >>> " read-from-stdin-line 
	( read until the program is killed )
	dup 0 = if 
		drop leave 
	else 
		( the pointer and length are in the wrong order so swap them and run )
		cr swap run 
	then 
again ;

: runRepl ." Hello lox repl" cr input-loop ;
