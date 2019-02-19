<template>
  <div id="app">
    <router-view></router-view>
  </div>
</template>

<script>
import HomePage from './components/HomePage.vue';

export default {
  name: 'app',
  components: {
    HomePage
  }
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
