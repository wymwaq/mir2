@echo off
setlocal

REM ����·��
set src_dir=D:\workspace\git-mir\mir2-database-wq\Wq\Exports\replace
set dest_dir=D:\workspace\git-mir\mir2\Wq\lan

REM �ļ�·������
set file_list=item map monster magic npc

REM ��ʾ�û�ȷ�ϲ���ӡ·����Ϣ
echo ��Ҫɾ������Ŀ��Ŀ¼�е��ļ���
for %%f in (%file_list%) do (
    echo - %dest_dir%\%%f\csv_V2K.csv
)
echo ���»س�����������رմ���ȡ������...
pause >nul

REM ɾ��Ŀ���ļ�
for %%f in (%file_list%) do (
    if exist "%dest_dir%\%%f\csv_V2K.csv" (
        echo ����ɾ���ļ� %%f\csv_V2K.csv...
        del /q "%dest_dir%\%%f\csv_V2K.csv"
    )
)

REM ����ǰȷ��Ŀ���ļ��д���
echo ���ڸ����ļ���������Ҫ���ļ���...
for %%f in (%file_list%) do (
    if not exist "%dest_dir%\%%f" (
        echo �����ļ��� %dest_dir%\%%f...
        mkdir "%dest_dir%\%%f"
    )
    copy "%src_dir%\%%f\csv_V2K.csv" "%dest_dir%\%%f\csv_V2K.csv"
)

echo ������ɣ�
pause
