@ECHO OFF
GOTO :_main

:_calculate
SET /A to_val=%~1
    SET /A NUMBER_ONE=1
    SET /A i=%NUMBER_ONE%
    SET /A j=%NUMBER_ONE%
    SET /A tmp=0

    SET /A val=0
    :_val
        IF %val%==%to_val% GOTO :val_
        SET /A val+=1
        SET /A tmp=%i%+%j%
        SET /A i=%j%
        SET /A j=%tmp%
        GOTO :_val
    :val_
    SET /A calculate=%j%/%i%
    GOTO :calculate
:calculate_

:_main
    CALL :_calculate 24
    GOTO :EOF
    :calculate
    ECHO %calculate%
    REM // CMD에서는 실수는 지원되지 않아 내림되어 1로 출력됨.
    CALL :main 0
    GOTO :EOF

:main_
:main
