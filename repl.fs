require run.fs

( create a buffer for the input )
1024 constant max-line
create temp-line max-line chars allot

( read up to max-line characters into the input buffer )
: read-from-stdin-line ( -- n buffer ) temp-line max-line accept temp-line swap ;

: input-loop begin 
	." >>> " read-from-stdin-line 
	( if the line has zero characters exit 
	TODO: This should actually check if we reached end of stdin instead of just checking zero characters )
	dup 0 = if 
		drop leave 
	else 
		( the pointer and length are in the wrong order so swap them and run )
		cr run 
	then 
again ;

: runRepl ." Hello lox repl" cr input-loop ;
