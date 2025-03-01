function applyOperations(nums: number[]): number[] {
  let arr: number[] = [];
  let numOfZeros: number = 0;
  for (let i = 0; i < nums.length; i++) {
    if (nums[i] == 0) numOfZeros++;
    else if (i + 1 < nums.length && nums[i] == nums[i + 1]) {
      arr.push(nums[i] * 2);
      numOfZeros++;
      i++;
    } else arr.push(nums[i]);
  }
  arr.push(...Array(numOfZeros).fill(0));
  return arr;
}
