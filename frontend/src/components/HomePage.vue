<template>
  <div class="main-content">
    <header class="jumbotron centered">
      <h1>Shitty Twitter</h1>
      <p>Go ahead, shitty tweet things!</p>
    </header>
    <div class="container">
      <div class="shitty-tweets" v-for="shittyTweet in shittyTweets" :key="shittyTweet.id">
        <shitty-tweet
          :shittyTweet="shittyTweet"
          />
      </div> 
    </div>
  </div>
</template>

<script>
import { mapState, mapActions } from 'vuex';
import ShittyTweet from './ShittyTweet';

export default {
  name: 'HelloWorld',
  components: {
    ShittyTweet,
  },
  data() {
    return {
      post: null,
    }
  },
  computed: {
    ...mapState(['shittyTweets'])
  },
  created() {
    this.getAllTweetsFromApi();
  },
  methods: {
    ...mapActions([
      'getAllTweetsFromApi',
    ]),
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
header {
  text-align: center;
  position: relative;
}
</style>
