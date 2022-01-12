require repl.fs
require run_file.fs

: main 
argc @ 1 -
dup 1 > if 
	." Usage: gforth lox.fs [script]" cr
else 1 = if
	1 arg runFile
else 
	runRepl
then then
;

main bye
