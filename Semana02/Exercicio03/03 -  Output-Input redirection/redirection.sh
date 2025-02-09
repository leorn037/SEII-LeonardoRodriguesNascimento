echo Hello World! > hello.txt

echo Good day to you! > hello.txt

echo Hello World! > hello.txt
echo Good day to you! >> hello.txt

wc -w hello.txt
wc -w < hello.txt

cat << EOF
wc -w <<< "Hello there worldcount!"