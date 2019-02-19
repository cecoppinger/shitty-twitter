/* eslint-disable linebreak-style */
module.exports = {
  devServer: {
    proxy: {
      '/api': {
        target: 'https://localhost:44303',
        changeOrigin: true,
      },
    },
  },
};
