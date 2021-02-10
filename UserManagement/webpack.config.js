const path = require('path');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");

const bundleFileName = 'bundle';
const dirName = './wwwroot/dist';

module.exports = (env, argv) => {
    return {
        mode: argv.mode === "production" ? "production" : "development",
        entry: ['./wwwroot/app.js', './wwwroot/styles.css'],
        output: {
            filename: bundleFileName + '.js',
            path: path.resolve(__dirname, dirName)
        },
        module: {
            rules: [{
                test: /\.css$/,
                use: [
                    MiniCssExtractPlugin.loader,
                    'css-loader',
                    'postcss-loader'
                ]
            }]
        },
        plugins: [
            new MiniCssExtractPlugin({
                filename: bundleFileName + '.css'
            })
        ]
    };
};