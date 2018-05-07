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

  "csharp/CrackingTheCodingInterview/_2_1/RemoveDuplicates"
  "csharp/CrackingTheCodingInterview/_2_2/KthToTheLast"
  "csharp/CrackingTheCodingInterview/_2_3/DeleteMiddleNode"
  "csharp/CrackingTheCodingInterview/_2_4/Partition"
  "csharp/CrackingTheCodingInterview/_2_5/SumLists"
  "csharp/CrackingTheCodingInterview/_2_6/Palindrome"
  "csharp/CrackingTheCodingInterview/_2_7/Intersection"
  "csharp/CrackingTheCodingInterview/_2_8/LoopDetection"

  "csharp/CrackingTheCodingInterview/_4_01/RouteBetweenNodes"
  "csharp/CrackingTheCodingInterview/_4_02/MinimalTree"
  "csharp/CrackingTheCodingInterview/_4_03/ListOfDepths"
  "csharp/CrackingTheCodingInterview/_4_04/CheckBalanced"
  "csharp/CrackingTheCodingInterview/_4_05/ValidateBST"
  "csharp/CrackingTheCodingInterview/_4_06/Successor"
  "csharp/CrackingTheCodingInterview/_4_07/BuildOrder"
  "csharp/CrackingTheCodingInterview/_4_08/FirstCommonAncestor"
  "csharp/CrackingTheCodingInterview/_4_09/BSTSequences"
  "csharp/CrackingTheCodingInterview/_4_10/CheckSubtree"
  "csharp/CrackingTheCodingInterview/_4_11/RandomNode"
  "csharp/CrackingTheCodingInterview/_4_12/PathsWithSum"

  "csharp/CrackingTheCodingInterview/_8_01/TripleStep"
  "csharp/CrackingTheCodingInterview/_8_02/RobotInAGrid"
  "csharp/CrackingTheCodingInterview/_8_03/MagicIndex"
  "csharp/CrackingTheCodingInterview/_8_04/PowerSet"
  "csharp/CrackingTheCodingInterview/_8_05/RecursiveMultiply"
  "csharp/CrackingTheCodingInterview/_8_06/TowersOfHanoi"
  "csharp/CrackingTheCodingInterview/_8_07/PermutationsWithoutDuplicates"
  "csharp/CrackingTheCodingInterview/_8_08/PermutationsWithDuplicates"
  "csharp/CrackingTheCodingInterview/_8_09/Parenthesis"
  "csharp/CrackingTheCodingInterview/_8_11/PaintFill"
  "csharp/CrackingTheCodingInterview/_8_12/Coins"
  "csharp/CrackingTheCodingInterview/_8_13/EightQueens"
  "csharp/CrackingTheCodingInterview/_8_14/StackOfBoxes"
  "csharp/CrackingTheCodingInterview/_8_15/BooleanEvaluation"

  "csharp/CrackingTheCodingInterview/_10_01/SortedMerge"
  "csharp/CrackingTheCodingInterview/_10_02/GroupAnagrams"
  "csharp/CrackingTheCodingInterview/_10_03/SearchInRotatedArray"
  "csharp/CrackingTheCodingInterview/_10_04/SortedSearchNoSize"
  "csharp/CrackingTheCodingInterview/_10_05/SparseSearch"
  "csharp/CrackingTheCodingInterview/_10_06/SortBigFile"
  "csharp/CrackingTheCodingInterview/_10_07/MissingInt"
  "csharp/CrackingTheCodingInterview/_10_08/FindDuplicates"
  "csharp/CrackingTheCodingInterview/_10_09/SortedMatrixSearch"
  "csharp/CrackingTheCodingInterview/_10_10/RankFromStream"
  "csharp/CrackingTheCodingInterview/_10_11/PeaksAndValleys"

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
