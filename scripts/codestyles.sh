#! /bin/sh

files=$(find . -name "*.cs")


for item in $files ; do

  uncrustify -c uncrustify.cfg --no-backup --mtime --if-changed --replace $item

done
