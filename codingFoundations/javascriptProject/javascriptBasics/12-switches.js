switch(expression) {
    case x:
      // code block
      break;
    case y:
      // code block
      break;
    default:
      // code block
    }

    let ingredients = "Salmon"

    switch (ingredients) {
      case "Ground Beef":
        console.log("I'll make Hamburgers.")
        break;
      case "Salmon":
        console.log("I'll make grilled Salmon.")
        break;
      case "Chicken":
        console.log("I'll make Chicken Tacos.")
        break;
      default:
        console.log("I guess I should order something")
    }  

    //Ex:
    let answer = "B"

    switch (answer) {
      case "A":
      case "B":
        console.log("Gryffindor")
        break;
      case "C":
      case "D":
        console.log("Hufflepuff")
        break;
      case "E":
      case "F":
        console.log("Ravenclaw")
        break;
      case "G":
      case "H":
        console.log("Slytherin")
        break;
      default:
        console.log("Must be a Muggle.")
    }