<template>
  <div id="app">
    <HelloWorld msg="Welcome to Your Vue.js App"/>
  </div>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue';

export default {
  name: 'app',
};
</script>

<style>
body {
  background: linear-gradient(to bottom, #0a4096, #377eef);
  background-attachment: fixed;
}
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
}
</style>
