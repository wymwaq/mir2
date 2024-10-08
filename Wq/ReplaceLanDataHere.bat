@echo off
setlocal

REM 定义路径
set src_dir=D:\workspace\git-mir\mir2-database-wq\Wq\Exports\replace
set dest_dir=D:\workspace\git-mir\mir2\Wq\lan

REM 文件路径数组
set file_list=item map monster magic npc

REM 提示用户确认并打印路径信息
echo 将要删除以下目标目录中的文件：
for %%f in (%file_list%) do (
    echo - %dest_dir%\%%f\csv_V2K.csv
)
echo 按下回车键继续，或关闭窗口取消操作...
pause >nul

REM 删除目标文件
for %%f in (%file_list%) do (
    if exist "%dest_dir%\%%f\csv_V2K.csv" (
        echo 正在删除文件 %%f\csv_V2K.csv...
        del /q "%dest_dir%\%%f\csv_V2K.csv"
    )
)

REM 复制前确保目标文件夹存在
echo 正在复制文件并创建必要的文件夹...
for %%f in (%file_list%) do (
    if not exist "%dest_dir%\%%f" (
        echo 创建文件夹 %dest_dir%\%%f...
        mkdir "%dest_dir%\%%f"
    )
    copy "%src_dir%\%%f\csv_V2K.csv" "%dest_dir%\%%f\csv_V2K.csv"
)

echo 操作完成！
pause
