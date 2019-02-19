import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    tweets: [],
    thisTweet: null,
  },
  mutations: {
    setAllTweets(store, data) {
      this.tweets = data;
    },
  },
  actions: {
    getAllTweetsFromApi(store) {
      
    },
  },
  getters: {

  },
});
