const path = require('path');
const argv = require('yargs').argv;
const HtmlWebpackPlugin = require('html-webpack-plugin');

const watch = argv.watch;

module.exports = {
    entry: './main.js',
    output: {
        filename: 'main-bundle.js',
        path: path.resolve(__dirname, 'dist')
    },
    watch: watch,
    module: {
        rules: [
            {
                test: /\.jsx$/,
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env', '@babel/preset-react']
                    }
                }
            }
        ]
    },
    plugins: [
        new HtmlWebpackPlugin({
          template: "index.html"
        })
    ]
};