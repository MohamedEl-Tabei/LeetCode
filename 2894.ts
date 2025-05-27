function differenceOfSums(n: number, m: number): number {
  let divisible = 0;
  let notDivisible = 0;
  for (let i = 1; i <= n; i++) {
    if (i % m == 0) divisible = divisible + i;
    else notDivisible = notDivisible + i;
  }
  return notDivisible - divisible;
}
