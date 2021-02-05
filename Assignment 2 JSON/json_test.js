//illustrating the function JSON.stringify()
var person = {
    name: "Alejandro Barragan",
    age: 23
}
console.log(JSON.stringify(person));

//illustrating the function JSON.parse()

const json = '{"First": "parse", "Last": "non-parse"}';
console.log(json);
const obj = JSON.parse(json);

console.log(obj.First);