//illustrating the function JSON.stringify()
var person = {
    name: "Alejandro Barragan",
    age: 22
}
console.log(JSON.stringify(person));

//illustrating the function JSON.parse()

const json = '{"First": "Alejandro", "Last": "Barragan"}';

const obj = JSON.parse(json);

console.log(obj.First);