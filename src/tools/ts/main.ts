import axios from 'axios'
import * as chalk from 'chalk'
import * as tool from './src/crossgen';
import { FlagArg } from './src/crossgen';

let option1:tool.Flag = '/r'
let option2:FlagArg = ['/JITPath','']


console.log(chalk.cyan(''))

// axios.get('https://httpbin.org/ip')
//     .then((response) => {
//         console.log(chalk.cyan(`Your IP is ${response.data.origin}`))
//     })