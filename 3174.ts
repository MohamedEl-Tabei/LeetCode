function clearDigits(s: string): string {
  let newString: string = "";
  for (let i = 0; i < s.length; i++) {
    if (Number(s[i]).toString() == "NaN") newString = newString + s[i];
    else {
      newString = newString.slice(0, newString.length - 1);
    }
  }
  return newString;
}
