function areAlmostEqual(s1: string, s2: string): boolean {
  let diffChar: string[] = [];
  if (s1 == s2) return true;
  if (s1.length != s2.length) return false;

  for (let i = 0; i < s1.length; i++) {
    if (s1[i] != s2[i]) {
      diffChar.push(s1[i]);
      diffChar.push(s2[i]);
    }
  }
  return (
    diffChar[0] == diffChar[3] &&
    diffChar[1] == diffChar[2] &&
    diffChar.length == 4
  );
}
