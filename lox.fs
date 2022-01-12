require repl.fs
require run.fs

: main 
argc @ 1 -
dup 1 > if 
	." Usage: gforth lox.fs [script]" cr
else 1 = if
	( if we only have one argument it is a filename )
	1 arg slurp-file run
else 
	( otherwise we can just do a repl )
	runRepl
then then
;

main bye
