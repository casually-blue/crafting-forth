require run.fs

1024 constant max-line
create temp-line max-line chars allot

: read-from-stdin-line temp-line max-line accept ;

: input-loop begin 
	." >>> " read-from-stdin-line 
	dup 0 = if 
		drop leave 
	else 
		temp-line cr swap run 
	then 
again ;

: runRepl ." Hello lox repl" cr input-loop ;
