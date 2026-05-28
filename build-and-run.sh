#!/bin/sh

set -e

PROJECT="CAT_ проект/CAT_ проект.csproj"
EXE="CAT_ проект/bin/Debug/CAT_ проект.exe"

if ! command -v msbuild >/dev/null 2>&1; then
    echo "Ошибка: msbuild не найден."
    echo "На Arch Linux установи Mono:"
    echo "sudo pacman -S mono"
    exit 1
fi

if ! command -v mono >/dev/null 2>&1; then
    echo "Ошибка: mono не найден."
    echo "На Arch Linux установи Mono:"
    echo "sudo pacman -S mono"
    exit 1
fi

echo "Сборка проекта..."
msbuild "$PROJECT" /nologo /verbosity:minimal

echo "Запуск приложения..."
mono "$EXE"
