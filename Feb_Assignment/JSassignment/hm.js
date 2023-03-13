// Problem1
let salaries = {
  John: 100,
  Ann: 160,
  Pete: 130,
};

let p1Sum = 0;
function getSum(obj) {
  for (let i in obj) {
    if (typeof obj[i] == "number") {
      p1Sum += obj[i];
    }
  }
}

getSum(salaries);
console.log(p1Sum);

// problem2
let menu = {
  width: 200,
  height: 300,
  title: "My menu",
};

function multiplyNumeric(obj) {
  for (let i in obj) {
    if (typeof obj[i] == "number") {
      obj[i] = obj[i] * 2;
    }
  }
}

multiplyNumeric(menu);
console.log(menu);

// problem3
var test = "haoyunzhang.1st@gamil.com";

function checkEmailId(str) {
  if (str.indexOf("@") !== -1 && str.indexOf(".") !== -1) {
    if (
      str.lastIndexOf("@") < str.lastIndexOf(".") &&
      str.lastIndexOf(".") > str.lastIndexOf("@") + 1
    ) {
      return true;
    } else {
      return false;
    }
  } else {
    return false;
  }
}

console.log(checkEmailId(test));

// problem4
function truncate(str, maxlength) {
  if (str.length > maxlength) {
    return str.slice(0, maxlength - 1) + "...";
  } else {
    return str;
  }
}

var test4 = "What I'd like to tell on this topic is:";
console.log(truncate(test4, 20));
console.log(truncate("Hi everyone!", 20));

// problem5
arr = ["James", "Brennie"];
arr.push("Robert");
var l = arr.length;
arr[Math.floor(l / 2)] = "Calvin";
console.log(arr);
let fi = arr.shift();
console.log(fi);

arr.unshift("Rose", "Regal");
console.log(arr);
