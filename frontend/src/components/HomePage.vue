<template>
  <div class="main-content">
    <header class="jumbotron">
      <h1>Shitty Twitter</h1>
      <p>Go ahead, shitty tweet things!</p>
    </header>
    <div class="container">

    </div>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'HelloWorld',
  data() {
    return {
      post: null,
    }
  },
  mounted () {
    axios.get('/api/shittytweets/1').then(response => { this.post = response.data });
  },  
};

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
#tweet-container {
  margin: 5px auto;
  padding: 30px;
  background-color: white;
  width: 50%;
  text-align: center;
}
</style>
