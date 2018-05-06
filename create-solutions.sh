#!/bin/bash

# Chapter 1
declare -a chapter1=(
  "csharp/CrackingTheCodingInterview/_1_1/IsUnique"
  "csharp/CrackingTheCodingInterview/_1_2/CheckPermutation"
  "csharp/CrackingTheCodingInterview/_1_3/Urlify"
  "csharp/CrackingTheCodingInterview/_1_4/PalindromePermutation"
  "csharp/CrackingTheCodingInterview/_1_5/OneAway"
  "csharp/CrackingTheCodingInterview/_1_6/StringCompression"
  "csharp/CrackingTheCodingInterview/_1_7/RotateMatrix"
  "csharp/CrackingTheCodingInterview/_1_8/ZeroMatrix"
  "csharp/CrackingTheCodingInterview/_1_9/StringRotation"
)

for i in "${chapter1[@]}"
do
  mkdir -p $i
  pushd $i
  dotnet new console
  popd
done

cd csharp/CrackingTheCodingInterview
dotnet new sln
