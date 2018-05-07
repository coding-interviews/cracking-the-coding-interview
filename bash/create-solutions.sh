#!/bin/bash

declare -a chapters=(
  "csharp/CrackingTheCodingInterview/_1_1/IsUnique"
  "csharp/CrackingTheCodingInterview/_1_2/CheckPermutation"
  "csharp/CrackingTheCodingInterview/_1_3/Urlify"
  "csharp/CrackingTheCodingInterview/_1_4/PalindromePermutation"
  "csharp/CrackingTheCodingInterview/_1_5/OneAway"
  "csharp/CrackingTheCodingInterview/_1_6/StringCompression"
  "csharp/CrackingTheCodingInterview/_1_7/RotateMatrix"
  "csharp/CrackingTheCodingInterview/_1_8/ZeroMatrix"
  "csharp/CrackingTheCodingInterview/_1_9/StringRotation"
  "csharp/CrackingTheCodingInterview/Utilities"
)

# Create the solution
root=csharp/CrackingTheCodingInterview
mkdir -p $root
pushd $root
dotnet new sln
popd

for i in "${chapters[@]}"
do
  # Create the project
  mkdir -p $i
  name=$(basename -- "$i")
  pushd $i
  dotnet new console --language C#
  popd

  # Add the project to the solution
  pushd $root
  dotnet sln add "../../${i}/${name}.csproj"
  popd
done
