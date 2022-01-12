require run.fs

( output the name of the input file and then run it )
: runFile ( n string -- ) ." running lox file: " 2dup type cr slurp-file run ;
