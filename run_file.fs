require run.fs

: runFile ." running lox file: " 2dup type cr slurp-file run ;
